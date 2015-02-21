using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

using BadPractise.EF;
using BadPractise.Wpf.Annotations;

namespace BadPractise.Wpf
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private ProductDto _selectedProduct;

        public MainPageViewModel()
        {
            Products = new ObservableCollection<ProductDto>();
            Inventory = new ObservableCollection<string>();

            // Opening lots of connections
            for (var i = 0; i < 10; i++)
            {
                using (var context = new MyDbContext())
                {
                    context.Products.FirstOrDefault();
                }
            }


            using (var context = new MyDbContext())
            {
                // SELECT * FROM
                foreach (var product in context.Products)
                {
                    Products.Add(new ProductDto
                    {
                        Id = product.ProductId,
                        Name = product.Name
                    });
                }

                // TODO - Move these into separate query classes and use output in app

                // Eager loading
                var products = context.Products
                    .Include(p => p.ProductSubcategory)
                    .Include(p => p.ProductSubcategory.ProductCategory)
                    .Select(p => p).ToList();

                // parameters are different sizes
                var p1 = context.Database.SqlQuery<Product>("SELECT * FROM Production.Product WHERE Name = @P0", "Five")
                    .ToList();

                var p2 =
                    context.Database.SqlQuery<Product>("SELECT * FROM Production.Product WHERE Name = @P0",
                        "TwentyEight")
                        .ToList();

                // SQL injection
                    context.Database.SqlQuery<Product>(string.Format("SELECT * FROM Production.Product WHERE Name = '{0}'", "UserData"))
                        .ToList();

                // query begins with %
                context.Products.Where(p => p.Name.Contains("b")).ToList();

                // read entire table
                context.Products.ToList();

                // N+1
                var salesPeople = from sp in context.SalesPersons
                    select sp;

                foreach (var salesPerson in salesPeople)
                {
                    foreach (var store in salesPerson.Stores)
                    {
                        Debug.WriteLine(store.Name);
                    }
                }
            }
        }

        public ObservableCollection<ProductDto> Products { get; set; }
        public ObservableCollection<string> Inventory { get; set; }

        public ProductDto SelectedProduct
        {
            get { return _selectedProduct; }
            set
            {
                if (Equals(value, _selectedProduct))
                    return;
                _selectedProduct = value;

                LoadInventoryForProduct(_selectedProduct.Id);
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void LoadInventoryForProduct(int productId)
        {
            using (var context = new MyDbContext())
            {
                // Filtering after db query
                var products = context.Products
                    .SelectMany(q => q.ProductInventories);

                var result = products.ToList();

                Inventory.Clear();
                foreach (var productInventory in result)
                {
                    if (productInventory.ProductId == productId)
                        Inventory.Add(productInventory.Location.Name + " " + productInventory.Quantity);
                }
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}