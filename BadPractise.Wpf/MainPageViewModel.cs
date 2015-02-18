using System.Collections.ObjectModel;
using System.ComponentModel;
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

            using (var context = new MyDbContext())
            {
                // SELECT * FROM
                foreach (var product in context.Products)
                {
                    Products.Add(new ProductDto {Id = product.ProductId, Name = product.Name});
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
                if (Equals(value, _selectedProduct)) return;
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
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}