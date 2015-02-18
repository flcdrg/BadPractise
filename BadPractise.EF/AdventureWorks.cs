

// This file was automatically generated.
// Do not make changes directly to this file - edit the template instead.
// 
// The following connection settings were used to generate this file
// 
//     Configuration file:     "BadPractise.EF\App.config"
//     Connection String Name: "MyDbContext"
//     Connection String:      "Server=.\SQL2014;Database=AdventureWorks2014;Trusted_Connection=True;MultipleActiveResultSets=true"

// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.5

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace BadPractise.EF
{
    // ************************************************************************
    // Unit of work
    public interface IMyDbContext : IDisposable
    {
        IDbSet<Address> Addresses { get; set; } // Address
        IDbSet<AddressType> AddressTypes { get; set; } // AddressType
        IDbSet<BillOfMaterial> BillOfMaterials { get; set; } // BillOfMaterials
        IDbSet<BusinessEntity> BusinessEntities { get; set; } // BusinessEntity
        IDbSet<BusinessEntityAddress> BusinessEntityAddresses { get; set; } // BusinessEntityAddress
        IDbSet<BusinessEntityContact> BusinessEntityContacts { get; set; } // BusinessEntityContact
        IDbSet<ContactType> ContactTypes { get; set; } // ContactType
        IDbSet<CountryRegion> CountryRegions { get; set; } // CountryRegion
        IDbSet<CountryRegionCurrency> CountryRegionCurrencies { get; set; } // CountryRegionCurrency
        IDbSet<CreditCard> CreditCards { get; set; } // CreditCard
        IDbSet<Culture> Cultures { get; set; } // Culture
        IDbSet<Currency> Currencies { get; set; } // Currency
        IDbSet<CurrencyRate> CurrencyRates { get; set; } // CurrencyRate
        IDbSet<Customer> Customers { get; set; } // Customer
        IDbSet<Department> Departments { get; set; } // Department
        IDbSet<Document> Documents { get; set; } // Document
        IDbSet<EmailAddress> EmailAddresses { get; set; } // EmailAddress
        IDbSet<Employee> Employees { get; set; } // Employee
        IDbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; } // EmployeeDepartmentHistory
        IDbSet<EmployeePayHistory> EmployeePayHistories { get; set; } // EmployeePayHistory
        IDbSet<Illustration> Illustrations { get; set; } // Illustration
        IDbSet<JobCandidate> JobCandidates { get; set; } // JobCandidate
        IDbSet<Location> Locations { get; set; } // Location
        IDbSet<Password> Passwords { get; set; } // Password
        IDbSet<Person> People { get; set; } // Person
        IDbSet<PersonCreditCard> PersonCreditCards { get; set; } // PersonCreditCard
        IDbSet<PersonPhone> PersonPhones { get; set; } // PersonPhone
        IDbSet<PhoneNumberType> PhoneNumberTypes { get; set; } // PhoneNumberType
        IDbSet<Product> Products { get; set; } // Product
        IDbSet<ProductCategory> ProductCategories { get; set; } // ProductCategory
        IDbSet<ProductCostHistory> ProductCostHistories { get; set; } // ProductCostHistory
        IDbSet<ProductDescription> ProductDescriptions { get; set; } // ProductDescription
        IDbSet<ProductDocument> ProductDocuments { get; set; } // ProductDocument
        IDbSet<ProductInventory> ProductInventories { get; set; } // ProductInventory
        IDbSet<ProductListPriceHistory> ProductListPriceHistories { get; set; } // ProductListPriceHistory
        IDbSet<ProductModel> ProductModels { get; set; } // ProductModel
        IDbSet<ProductModelIllustration> ProductModelIllustrations { get; set; } // ProductModelIllustration
        IDbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; } // ProductModelProductDescriptionCulture
        IDbSet<ProductPhoto> ProductPhotoes { get; set; } // ProductPhoto
        IDbSet<ProductProductPhoto> ProductProductPhotoes { get; set; } // ProductProductPhoto
        IDbSet<ProductReview> ProductReviews { get; set; } // ProductReview
        IDbSet<ProductSubcategory> ProductSubcategories { get; set; } // ProductSubcategory
        IDbSet<ProductVendor> ProductVendors { get; set; } // ProductVendor
        IDbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; } // PurchaseOrderDetail
        IDbSet<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; } // PurchaseOrderHeader
        IDbSet<SalesOrderDetail> SalesOrderDetails { get; set; } // SalesOrderDetail
        IDbSet<SalesOrderHeader> SalesOrderHeaders { get; set; } // SalesOrderHeader
        IDbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; } // SalesOrderHeaderSalesReason
        IDbSet<SalesPerson> SalesPersons { get; set; } // SalesPerson
        IDbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; } // SalesPersonQuotaHistory
        IDbSet<SalesReason> SalesReasons { get; set; } // SalesReason
        IDbSet<SalesTaxRate> SalesTaxRates { get; set; } // SalesTaxRate
        IDbSet<SalesTerritory> SalesTerritories { get; set; } // SalesTerritory
        IDbSet<SalesTerritoryHistory> SalesTerritoryHistories { get; set; } // SalesTerritoryHistory
        IDbSet<ScrapReason> ScrapReasons { get; set; } // ScrapReason
        IDbSet<Shift> Shifts { get; set; } // Shift
        IDbSet<ShipMethod> ShipMethods { get; set; } // ShipMethod
        IDbSet<ShoppingCartItem> ShoppingCartItems { get; set; } // ShoppingCartItem
        IDbSet<SpecialOffer> SpecialOffers { get; set; } // SpecialOffer
        IDbSet<SpecialOfferProduct> SpecialOfferProducts { get; set; } // SpecialOfferProduct
        IDbSet<StateProvince> StateProvinces { get; set; } // StateProvince
        IDbSet<Store> Stores { get; set; } // Store
        IDbSet<TransactionHistory> TransactionHistories { get; set; } // TransactionHistory
        IDbSet<TransactionHistoryArchive> TransactionHistoryArchives { get; set; } // TransactionHistoryArchive
        IDbSet<UnitMeasure> UnitMeasures { get; set; } // UnitMeasure
        IDbSet<Vendor> Vendors { get; set; } // Vendor
        IDbSet<WorkOrder> WorkOrders { get; set; } // WorkOrder
        IDbSet<WorkOrderRouting> WorkOrderRoutings { get; set; } // WorkOrderRouting

        int SaveChanges();
    }

    // ************************************************************************
    // Database context
    public class MyDbContext : DbContext, IMyDbContext
    {
        public IDbSet<Address> Addresses { get; set; } // Address
        public IDbSet<AddressType> AddressTypes { get; set; } // AddressType
        public IDbSet<BillOfMaterial> BillOfMaterials { get; set; } // BillOfMaterials
        public IDbSet<BusinessEntity> BusinessEntities { get; set; } // BusinessEntity
        public IDbSet<BusinessEntityAddress> BusinessEntityAddresses { get; set; } // BusinessEntityAddress
        public IDbSet<BusinessEntityContact> BusinessEntityContacts { get; set; } // BusinessEntityContact
        public IDbSet<ContactType> ContactTypes { get; set; } // ContactType
        public IDbSet<CountryRegion> CountryRegions { get; set; } // CountryRegion
        public IDbSet<CountryRegionCurrency> CountryRegionCurrencies { get; set; } // CountryRegionCurrency
        public IDbSet<CreditCard> CreditCards { get; set; } // CreditCard
        public IDbSet<Culture> Cultures { get; set; } // Culture
        public IDbSet<Currency> Currencies { get; set; } // Currency
        public IDbSet<CurrencyRate> CurrencyRates { get; set; } // CurrencyRate
        public IDbSet<Customer> Customers { get; set; } // Customer
        public IDbSet<Department> Departments { get; set; } // Department
        public IDbSet<Document> Documents { get; set; } // Document
        public IDbSet<EmailAddress> EmailAddresses { get; set; } // EmailAddress
        public IDbSet<Employee> Employees { get; set; } // Employee
        public IDbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; } // EmployeeDepartmentHistory
        public IDbSet<EmployeePayHistory> EmployeePayHistories { get; set; } // EmployeePayHistory
        public IDbSet<Illustration> Illustrations { get; set; } // Illustration
        public IDbSet<JobCandidate> JobCandidates { get; set; } // JobCandidate
        public IDbSet<Location> Locations { get; set; } // Location
        public IDbSet<Password> Passwords { get; set; } // Password
        public IDbSet<Person> People { get; set; } // Person
        public IDbSet<PersonCreditCard> PersonCreditCards { get; set; } // PersonCreditCard
        public IDbSet<PersonPhone> PersonPhones { get; set; } // PersonPhone
        public IDbSet<PhoneNumberType> PhoneNumberTypes { get; set; } // PhoneNumberType
        public IDbSet<Product> Products { get; set; } // Product
        public IDbSet<ProductCategory> ProductCategories { get; set; } // ProductCategory
        public IDbSet<ProductCostHistory> ProductCostHistories { get; set; } // ProductCostHistory
        public IDbSet<ProductDescription> ProductDescriptions { get; set; } // ProductDescription
        public IDbSet<ProductDocument> ProductDocuments { get; set; } // ProductDocument
        public IDbSet<ProductInventory> ProductInventories { get; set; } // ProductInventory
        public IDbSet<ProductListPriceHistory> ProductListPriceHistories { get; set; } // ProductListPriceHistory
        public IDbSet<ProductModel> ProductModels { get; set; } // ProductModel
        public IDbSet<ProductModelIllustration> ProductModelIllustrations { get; set; } // ProductModelIllustration
        public IDbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; } // ProductModelProductDescriptionCulture
        public IDbSet<ProductPhoto> ProductPhotoes { get; set; } // ProductPhoto
        public IDbSet<ProductProductPhoto> ProductProductPhotoes { get; set; } // ProductProductPhoto
        public IDbSet<ProductReview> ProductReviews { get; set; } // ProductReview
        public IDbSet<ProductSubcategory> ProductSubcategories { get; set; } // ProductSubcategory
        public IDbSet<ProductVendor> ProductVendors { get; set; } // ProductVendor
        public IDbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; } // PurchaseOrderDetail
        public IDbSet<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; } // PurchaseOrderHeader
        public IDbSet<SalesOrderDetail> SalesOrderDetails { get; set; } // SalesOrderDetail
        public IDbSet<SalesOrderHeader> SalesOrderHeaders { get; set; } // SalesOrderHeader
        public IDbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; } // SalesOrderHeaderSalesReason
        public IDbSet<SalesPerson> SalesPersons { get; set; } // SalesPerson
        public IDbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; } // SalesPersonQuotaHistory
        public IDbSet<SalesReason> SalesReasons { get; set; } // SalesReason
        public IDbSet<SalesTaxRate> SalesTaxRates { get; set; } // SalesTaxRate
        public IDbSet<SalesTerritory> SalesTerritories { get; set; } // SalesTerritory
        public IDbSet<SalesTerritoryHistory> SalesTerritoryHistories { get; set; } // SalesTerritoryHistory
        public IDbSet<ScrapReason> ScrapReasons { get; set; } // ScrapReason
        public IDbSet<Shift> Shifts { get; set; } // Shift
        public IDbSet<ShipMethod> ShipMethods { get; set; } // ShipMethod
        public IDbSet<ShoppingCartItem> ShoppingCartItems { get; set; } // ShoppingCartItem
        public IDbSet<SpecialOffer> SpecialOffers { get; set; } // SpecialOffer
        public IDbSet<SpecialOfferProduct> SpecialOfferProducts { get; set; } // SpecialOfferProduct
        public IDbSet<StateProvince> StateProvinces { get; set; } // StateProvince
        public IDbSet<Store> Stores { get; set; } // Store
        public IDbSet<TransactionHistory> TransactionHistories { get; set; } // TransactionHistory
        public IDbSet<TransactionHistoryArchive> TransactionHistoryArchives { get; set; } // TransactionHistoryArchive
        public IDbSet<UnitMeasure> UnitMeasures { get; set; } // UnitMeasure
        public IDbSet<Vendor> Vendors { get; set; } // Vendor
        public IDbSet<WorkOrder> WorkOrders { get; set; } // WorkOrder
        public IDbSet<WorkOrderRouting> WorkOrderRoutings { get; set; } // WorkOrderRouting

        static MyDbContext()
        {
            Database.SetInitializer<MyDbContext>(null);
        }

        public MyDbContext()
            : base("Name=MyDbContext")
        {
        }

        public MyDbContext(string connectionString) : base(connectionString)
        {
        }

        public MyDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AddressConfiguration());
            modelBuilder.Configurations.Add(new AddressTypeConfiguration());
            modelBuilder.Configurations.Add(new BillOfMaterialConfiguration());
            modelBuilder.Configurations.Add(new BusinessEntityConfiguration());
            modelBuilder.Configurations.Add(new BusinessEntityAddressConfiguration());
            modelBuilder.Configurations.Add(new BusinessEntityContactConfiguration());
            modelBuilder.Configurations.Add(new ContactTypeConfiguration());
            modelBuilder.Configurations.Add(new CountryRegionConfiguration());
            modelBuilder.Configurations.Add(new CountryRegionCurrencyConfiguration());
            modelBuilder.Configurations.Add(new CreditCardConfiguration());
            modelBuilder.Configurations.Add(new CultureConfiguration());
            modelBuilder.Configurations.Add(new CurrencyConfiguration());
            modelBuilder.Configurations.Add(new CurrencyRateConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new DepartmentConfiguration());
            modelBuilder.Configurations.Add(new DocumentConfiguration());
            modelBuilder.Configurations.Add(new EmailAddressConfiguration());
            modelBuilder.Configurations.Add(new EmployeeConfiguration());
            modelBuilder.Configurations.Add(new EmployeeDepartmentHistoryConfiguration());
            modelBuilder.Configurations.Add(new EmployeePayHistoryConfiguration());
            modelBuilder.Configurations.Add(new IllustrationConfiguration());
            modelBuilder.Configurations.Add(new JobCandidateConfiguration());
            modelBuilder.Configurations.Add(new LocationConfiguration());
            modelBuilder.Configurations.Add(new PasswordConfiguration());
            modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.Configurations.Add(new PersonCreditCardConfiguration());
            modelBuilder.Configurations.Add(new PersonPhoneConfiguration());
            modelBuilder.Configurations.Add(new PhoneNumberTypeConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new ProductCategoryConfiguration());
            modelBuilder.Configurations.Add(new ProductCostHistoryConfiguration());
            modelBuilder.Configurations.Add(new ProductDescriptionConfiguration());
            modelBuilder.Configurations.Add(new ProductDocumentConfiguration());
            modelBuilder.Configurations.Add(new ProductInventoryConfiguration());
            modelBuilder.Configurations.Add(new ProductListPriceHistoryConfiguration());
            modelBuilder.Configurations.Add(new ProductModelConfiguration());
            modelBuilder.Configurations.Add(new ProductModelIllustrationConfiguration());
            modelBuilder.Configurations.Add(new ProductModelProductDescriptionCultureConfiguration());
            modelBuilder.Configurations.Add(new ProductPhotoConfiguration());
            modelBuilder.Configurations.Add(new ProductProductPhotoConfiguration());
            modelBuilder.Configurations.Add(new ProductReviewConfiguration());
            modelBuilder.Configurations.Add(new ProductSubcategoryConfiguration());
            modelBuilder.Configurations.Add(new ProductVendorConfiguration());
            modelBuilder.Configurations.Add(new PurchaseOrderDetailConfiguration());
            modelBuilder.Configurations.Add(new PurchaseOrderHeaderConfiguration());
            modelBuilder.Configurations.Add(new SalesOrderDetailConfiguration());
            modelBuilder.Configurations.Add(new SalesOrderHeaderConfiguration());
            modelBuilder.Configurations.Add(new SalesOrderHeaderSalesReasonConfiguration());
            modelBuilder.Configurations.Add(new SalesPersonConfiguration());
            modelBuilder.Configurations.Add(new SalesPersonQuotaHistoryConfiguration());
            modelBuilder.Configurations.Add(new SalesReasonConfiguration());
            modelBuilder.Configurations.Add(new SalesTaxRateConfiguration());
            modelBuilder.Configurations.Add(new SalesTerritoryConfiguration());
            modelBuilder.Configurations.Add(new SalesTerritoryHistoryConfiguration());
            modelBuilder.Configurations.Add(new ScrapReasonConfiguration());
            modelBuilder.Configurations.Add(new ShiftConfiguration());
            modelBuilder.Configurations.Add(new ShipMethodConfiguration());
            modelBuilder.Configurations.Add(new ShoppingCartItemConfiguration());
            modelBuilder.Configurations.Add(new SpecialOfferConfiguration());
            modelBuilder.Configurations.Add(new SpecialOfferProductConfiguration());
            modelBuilder.Configurations.Add(new StateProvinceConfiguration());
            modelBuilder.Configurations.Add(new StoreConfiguration());
            modelBuilder.Configurations.Add(new TransactionHistoryConfiguration());
            modelBuilder.Configurations.Add(new TransactionHistoryArchiveConfiguration());
            modelBuilder.Configurations.Add(new UnitMeasureConfiguration());
            modelBuilder.Configurations.Add(new VendorConfiguration());
            modelBuilder.Configurations.Add(new WorkOrderConfiguration());
            modelBuilder.Configurations.Add(new WorkOrderRoutingConfiguration());
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new AddressConfiguration(schema));
            modelBuilder.Configurations.Add(new AddressTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new BillOfMaterialConfiguration(schema));
            modelBuilder.Configurations.Add(new BusinessEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new BusinessEntityAddressConfiguration(schema));
            modelBuilder.Configurations.Add(new BusinessEntityContactConfiguration(schema));
            modelBuilder.Configurations.Add(new ContactTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new CountryRegionConfiguration(schema));
            modelBuilder.Configurations.Add(new CountryRegionCurrencyConfiguration(schema));
            modelBuilder.Configurations.Add(new CreditCardConfiguration(schema));
            modelBuilder.Configurations.Add(new CultureConfiguration(schema));
            modelBuilder.Configurations.Add(new CurrencyConfiguration(schema));
            modelBuilder.Configurations.Add(new CurrencyRateConfiguration(schema));
            modelBuilder.Configurations.Add(new CustomerConfiguration(schema));
            modelBuilder.Configurations.Add(new DepartmentConfiguration(schema));
            modelBuilder.Configurations.Add(new DocumentConfiguration(schema));
            modelBuilder.Configurations.Add(new EmailAddressConfiguration(schema));
            modelBuilder.Configurations.Add(new EmployeeConfiguration(schema));
            modelBuilder.Configurations.Add(new EmployeeDepartmentHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new EmployeePayHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new IllustrationConfiguration(schema));
            modelBuilder.Configurations.Add(new JobCandidateConfiguration(schema));
            modelBuilder.Configurations.Add(new LocationConfiguration(schema));
            modelBuilder.Configurations.Add(new PasswordConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonCreditCardConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonPhoneConfiguration(schema));
            modelBuilder.Configurations.Add(new PhoneNumberTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductCategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductCostHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductDescriptionConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductDocumentConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductInventoryConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductListPriceHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductModelConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductModelIllustrationConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductModelProductDescriptionCultureConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductPhotoConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductProductPhotoConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductReviewConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductSubcategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductVendorConfiguration(schema));
            modelBuilder.Configurations.Add(new PurchaseOrderDetailConfiguration(schema));
            modelBuilder.Configurations.Add(new PurchaseOrderHeaderConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesOrderDetailConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesOrderHeaderConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesOrderHeaderSalesReasonConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesPersonConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesPersonQuotaHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesReasonConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesTaxRateConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesTerritoryConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesTerritoryHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new ScrapReasonConfiguration(schema));
            modelBuilder.Configurations.Add(new ShiftConfiguration(schema));
            modelBuilder.Configurations.Add(new ShipMethodConfiguration(schema));
            modelBuilder.Configurations.Add(new ShoppingCartItemConfiguration(schema));
            modelBuilder.Configurations.Add(new SpecialOfferConfiguration(schema));
            modelBuilder.Configurations.Add(new SpecialOfferProductConfiguration(schema));
            modelBuilder.Configurations.Add(new StateProvinceConfiguration(schema));
            modelBuilder.Configurations.Add(new StoreConfiguration(schema));
            modelBuilder.Configurations.Add(new TransactionHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new TransactionHistoryArchiveConfiguration(schema));
            modelBuilder.Configurations.Add(new UnitMeasureConfiguration(schema));
            modelBuilder.Configurations.Add(new VendorConfiguration(schema));
            modelBuilder.Configurations.Add(new WorkOrderConfiguration(schema));
            modelBuilder.Configurations.Add(new WorkOrderRoutingConfiguration(schema));
            return modelBuilder;
        }
    }

    // ************************************************************************
    // POCO classes

    // Address
    public class Address
    {
        public int AddressId { get; set; } // AddressID (Primary key). Primary key for Address records.
        public string AddressLine1 { get; set; } // AddressLine1. First street address line.
        public string AddressLine2 { get; set; } // AddressLine2. Second street address line.
        public string City { get; set; } // City. Name of the city.
        public int StateProvinceId { get; set; } // StateProvinceID. Unique identification number for the state or province. Foreign key to StateProvince table.
        public string PostalCode { get; set; } // PostalCode. Postal code for the street address.
        public System.Data.Entity.Spatial.DbGeography SpatialLocation { get; set; } // SpatialLocation. Latitude and longitude of this address.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; } // Many to many mapping
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders_BillToAddressId { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_Address_BillToAddressID
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders_ShipToAddressId { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_Address_ShipToAddressID

        // Foreign keys
        public virtual StateProvince StateProvince { get; set; } // FK_Address_StateProvince_StateProvinceID

        public Address()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            BusinessEntityAddresses = new List<BusinessEntityAddress>();
            SalesOrderHeaders_BillToAddressId = new List<SalesOrderHeader>();
            SalesOrderHeaders_ShipToAddressId = new List<SalesOrderHeader>();
        }
    }

    // AddressType
    public class AddressType
    {
        public int AddressTypeId { get; set; } // AddressTypeID (Primary key). Primary key for AddressType records.
        public string Name { get; set; } // Name. Address type description. For example, Billing, Home, or Shipping.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; } // Many to many mapping

        public AddressType()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            BusinessEntityAddresses = new List<BusinessEntityAddress>();
        }
    }

    // BillOfMaterials
    public class BillOfMaterial
    {
        public int BillOfMaterialsId { get; set; } // BillOfMaterialsID (Primary key). Primary key for BillOfMaterials records.
        public int? ProductAssemblyId { get; set; } // ProductAssemblyID. Parent product identification number. Foreign key to Product.ProductID.
        public int ComponentId { get; set; } // ComponentID. Component identification number. Foreign key to Product.ProductID.
        public DateTime StartDate { get; set; } // StartDate. Date the component started being used in the assembly item.
        public DateTime? EndDate { get; set; } // EndDate. Date the component stopped being used in the assembly item.
        public string UnitMeasureCode { get; set; } // UnitMeasureCode. Standard code identifying the unit of measure for the quantity.
        public short BomLevel { get; set; } // BOMLevel. Indicates the depth the component is from its parent (AssemblyID).
        public decimal PerAssemblyQty { get; set; } // PerAssemblyQty. Quantity of the component needed to create the assembly.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Product Product_ComponentId { get; set; } // FK_BillOfMaterials_Product_ComponentID
        public virtual Product Product_ProductAssemblyId { get; set; } // FK_BillOfMaterials_Product_ProductAssemblyID
        public virtual UnitMeasure UnitMeasure { get; set; } // FK_BillOfMaterials_UnitMeasure_UnitMeasureCode

        public BillOfMaterial()
        {
            StartDate = System.DateTime.Now;
            PerAssemblyQty = 1.00m;
            ModifiedDate = System.DateTime.Now;
        }
    }

    // BusinessEntity
    public class BusinessEntity
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key for all customers, vendors, and employees.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; } // Many to many mapping
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; } // Many to many mapping
        public virtual Person Person { get; set; } // Person.FK_Person_BusinessEntity_BusinessEntityID
        public virtual Store Store { get; set; } // Store.FK_Store_BusinessEntity_BusinessEntityID
        public virtual Vendor Vendor { get; set; } // Vendor.FK_Vendor_BusinessEntity_BusinessEntityID

        public BusinessEntity()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            BusinessEntityAddresses = new List<BusinessEntityAddress>();
            BusinessEntityContacts = new List<BusinessEntityContact>();
        }
    }

    // BusinessEntityAddress
    public class BusinessEntityAddress
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key. Foreign key to BusinessEntity.BusinessEntityID.
        public int AddressId { get; set; } // AddressID (Primary key). Primary key. Foreign key to Address.AddressID.
        public int AddressTypeId { get; set; } // AddressTypeID (Primary key). Primary key. Foreign key to AddressType.AddressTypeID.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Address Address { get; set; } // FK_BusinessEntityAddress_Address_AddressID
        public virtual AddressType AddressType { get; set; } // FK_BusinessEntityAddress_AddressType_AddressTypeID
        public virtual BusinessEntity BusinessEntity { get; set; } // FK_BusinessEntityAddress_BusinessEntity_BusinessEntityID

        public BusinessEntityAddress()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

    // BusinessEntityContact
    public class BusinessEntityContact
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key. Foreign key to BusinessEntity.BusinessEntityID.
        public int PersonId { get; set; } // PersonID (Primary key). Primary key. Foreign key to Person.BusinessEntityID.
        public int ContactTypeId { get; set; } // ContactTypeID (Primary key). Primary key.  Foreign key to ContactType.ContactTypeID.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual BusinessEntity BusinessEntity { get; set; } // FK_BusinessEntityContact_BusinessEntity_BusinessEntityID
        public virtual ContactType ContactType { get; set; } // FK_BusinessEntityContact_ContactType_ContactTypeID
        public virtual Person Person { get; set; } // FK_BusinessEntityContact_Person_PersonID

        public BusinessEntityContact()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

    // ContactType
    public class ContactType
    {
        public int ContactTypeId { get; set; } // ContactTypeID (Primary key). Primary key for ContactType records.
        public string Name { get; set; } // Name. Contact type description.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; } // Many to many mapping

        public ContactType()
        {
            ModifiedDate = System.DateTime.Now;
            BusinessEntityContacts = new List<BusinessEntityContact>();
        }
    }

    // CountryRegion
    public class CountryRegion
    {
        public string CountryRegionCode { get; set; } // CountryRegionCode (Primary key). ISO standard code for countries and regions.
        public string Name { get; set; } // Name. Country or region name.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<CountryRegionCurrency> CountryRegionCurrencies { get; set; } // Many to many mapping
        public virtual ICollection<SalesTerritory> SalesTerritories { get; set; } // SalesTerritory.FK_SalesTerritory_CountryRegion_CountryRegionCode
        public virtual ICollection<StateProvince> StateProvinces { get; set; } // StateProvince.FK_StateProvince_CountryRegion_CountryRegionCode

        public CountryRegion()
        {
            ModifiedDate = System.DateTime.Now;
            CountryRegionCurrencies = new List<CountryRegionCurrency>();
            SalesTerritories = new List<SalesTerritory>();
            StateProvinces = new List<StateProvince>();
        }
    }

    // CountryRegionCurrency
    public class CountryRegionCurrency
    {
        public string CountryRegionCode { get; set; } // CountryRegionCode (Primary key). ISO code for countries and regions. Foreign key to CountryRegion.CountryRegionCode.
        public string CurrencyCode { get; set; } // CurrencyCode (Primary key). ISO standard currency code. Foreign key to Currency.CurrencyCode.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual CountryRegion CountryRegion { get; set; } // FK_CountryRegionCurrency_CountryRegion_CountryRegionCode
        public virtual Currency Currency { get; set; } // FK_CountryRegionCurrency_Currency_CurrencyCode

        public CountryRegionCurrency()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // CreditCard
    public class CreditCard
    {
        public int CreditCardId { get; set; } // CreditCardID (Primary key). Primary key for CreditCard records.
        public string CardType { get; set; } // CardType. Credit card name.
        public string CardNumber { get; set; } // CardNumber. Credit card number.
        public byte ExpMonth { get; set; } // ExpMonth. Credit card expiration month.
        public short ExpYear { get; set; } // ExpYear. Credit card expiration year.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<PersonCreditCard> PersonCreditCards { get; set; } // Many to many mapping
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_CreditCard_CreditCardID

        public CreditCard()
        {
            ModifiedDate = System.DateTime.Now;
            PersonCreditCards = new List<PersonCreditCard>();
            SalesOrderHeaders = new List<SalesOrderHeader>();
        }
    }

    // Culture
    public class Culture
    {
        public string CultureId { get; set; } // CultureID (Primary key). Primary key for Culture records.
        public string Name { get; set; } // Name. Culture description.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; } // Many to many mapping

        public Culture()
        {
            ModifiedDate = System.DateTime.Now;
            ProductModelProductDescriptionCultures = new List<ProductModelProductDescriptionCulture>();
        }
    }

    // Currency
    public class Currency
    {
        public string CurrencyCode { get; set; } // CurrencyCode (Primary key). The ISO code for the Currency.
        public string Name { get; set; } // Name. Currency name.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<CountryRegionCurrency> CountryRegionCurrencies { get; set; } // Many to many mapping
        public virtual ICollection<CurrencyRate> CurrencyRates_FromCurrencyCode { get; set; } // CurrencyRate.FK_CurrencyRate_Currency_FromCurrencyCode
        public virtual ICollection<CurrencyRate> CurrencyRates_ToCurrencyCode { get; set; } // CurrencyRate.FK_CurrencyRate_Currency_ToCurrencyCode

        public Currency()
        {
            ModifiedDate = System.DateTime.Now;
            CountryRegionCurrencies = new List<CountryRegionCurrency>();
            CurrencyRates_FromCurrencyCode = new List<CurrencyRate>();
            CurrencyRates_ToCurrencyCode = new List<CurrencyRate>();
        }
    }

    // CurrencyRate
    public class CurrencyRate
    {
        public int CurrencyRateId { get; set; } // CurrencyRateID (Primary key). Primary key for CurrencyRate records.
        public DateTime CurrencyRateDate { get; set; } // CurrencyRateDate. Date and time the exchange rate was obtained.
        public string FromCurrencyCode { get; set; } // FromCurrencyCode. Exchange rate was converted from this currency code.
        public string ToCurrencyCode { get; set; } // ToCurrencyCode. Exchange rate was converted to this currency code.
        public decimal AverageRate { get; set; } // AverageRate. Average exchange rate for the day.
        public decimal EndOfDayRate { get; set; } // EndOfDayRate. Final exchange rate for the day.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_CurrencyRate_CurrencyRateID

        // Foreign keys
        public virtual Currency Currency_FromCurrencyCode { get; set; } // FK_CurrencyRate_Currency_FromCurrencyCode
        public virtual Currency Currency_ToCurrencyCode { get; set; } // FK_CurrencyRate_Currency_ToCurrencyCode

        public CurrencyRate()
        {
            ModifiedDate = System.DateTime.Now;
            SalesOrderHeaders = new List<SalesOrderHeader>();
        }
    }

    // Customer
    public class Customer
    {
        public int CustomerId { get; set; } // CustomerID (Primary key). Primary key.
        public int? PersonId { get; set; } // PersonID. Foreign key to Person.BusinessEntityID
        public int? StoreId { get; set; } // StoreID. Foreign key to Store.BusinessEntityID
        public int? TerritoryId { get; set; } // TerritoryID. ID of the territory in which the customer is located. Foreign key to SalesTerritory.SalesTerritoryID.
        public string AccountNumber { get; internal set; } // AccountNumber. Unique number identifying the customer assigned by the accounting system.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_Customer_CustomerID

        // Foreign keys
        public virtual Person Person { get; set; } // FK_Customer_Person_PersonID
        public virtual SalesTerritory SalesTerritory { get; set; } // FK_Customer_SalesTerritory_TerritoryID
        public virtual Store Store { get; set; } // FK_Customer_Store_StoreID

        public Customer()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            SalesOrderHeaders = new List<SalesOrderHeader>();
        }
    }

    // Department
    public class Department
    {
        public short DepartmentId { get; set; } // DepartmentID (Primary key). Primary key for Department records.
        public string Name { get; set; } // Name. Name of the department.
        public string GroupName { get; set; } // GroupName. Name of the group to which the department belongs.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; } // Many to many mapping

        public Department()
        {
            ModifiedDate = System.DateTime.Now;
            EmployeeDepartmentHistories = new List<EmployeeDepartmentHistory>();
        }
    }

    // Document
    public class Document
    {
        public string DocumentNode { get; set; } // DocumentNode (Primary key). Primary key for Document records.
        public short? DocumentLevel { get; internal set; } // DocumentLevel. Depth in the document hierarchy.
        public string Title { get; set; } // Title. Title of the document.
        public int Owner { get; set; } // Owner. Employee who controls the document.  Foreign key to Employee.BusinessEntityID
        public bool FolderFlag { get; set; } // FolderFlag. 0 = This is a folder, 1 = This is a document.
        public string FileName { get; set; } // FileName. File name of the document
        public string FileExtension { get; set; } // FileExtension. File extension indicating the document type. For example, .doc or .txt.
        public string Revision { get; set; } // Revision. Revision number of the document.
        public int ChangeNumber { get; set; } // ChangeNumber. Engineering change approval number.
        public byte Status { get; set; } // Status. 1 = Pending approval, 2 = Approved, 3 = Obsolete
        public string DocumentSummary { get; set; } // DocumentSummary. Document abstract.
        public byte[] Document_ { get; set; } // Document. Complete document.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Required for FileStream.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<ProductDocument> ProductDocuments { get; set; } // Many to many mapping

        // Foreign keys
        public virtual Employee Employee { get; set; } // FK_Document_Employee_Owner

        public Document()
        {
            FolderFlag = false;
            ChangeNumber = 0;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            ProductDocuments = new List<ProductDocument>();
        }
    }

    // EmailAddress
    public class EmailAddress
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key. Person associated with this email address.  Foreign key to Person.BusinessEntityID
        public int EmailAddressId { get; set; } // EmailAddressID (Primary key). Primary key. ID of this email address.
        public string EmailAddress_ { get; set; } // EmailAddress. E-mail address for the person.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Person Person { get; set; } // FK_EmailAddress_Person_BusinessEntityID

        public EmailAddress()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

    // Employee
    public class Employee
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key for Employee records.  Foreign key to BusinessEntity.BusinessEntityID.
        public string NationalIdNumber { get; set; } // NationalIDNumber. Unique national identification number such as a social security number.
        public string LoginId { get; set; } // LoginID. Network login.
        public string OrganizationNode { get; set; } // OrganizationNode. Where the employee is located in corporate hierarchy.
        public short? OrganizationLevel { get; internal set; } // OrganizationLevel. The depth of the employee in the corporate hierarchy.
        public string JobTitle { get; set; } // JobTitle. Work title such as Buyer or Sales Representative.
        public DateTime BirthDate { get; set; } // BirthDate. Date of birth.
        public string MaritalStatus { get; set; } // MaritalStatus. M = Married, S = Single
        public string Gender { get; set; } // Gender. M = Male, F = Female
        public DateTime HireDate { get; set; } // HireDate. Employee hired on this date.
        public bool SalariedFlag { get; set; } // SalariedFlag. Job classification. 0 = Hourly, not exempt from collective bargaining. 1 = Salaried, exempt from collective bargaining.
        public short VacationHours { get; set; } // VacationHours. Number of available vacation hours.
        public short SickLeaveHours { get; set; } // SickLeaveHours. Number of available sick leave hours.
        public bool CurrentFlag { get; set; } // CurrentFlag. 0 = Inactive, 1 = Active
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Document> Documents { get; set; } // Document.FK_Document_Employee_Owner
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; } // Many to many mapping
        public virtual ICollection<EmployeePayHistory> EmployeePayHistories { get; set; } // Many to many mapping
        public virtual ICollection<JobCandidate> JobCandidates { get; set; } // JobCandidate.FK_JobCandidate_Employee_BusinessEntityID
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; } // PurchaseOrderHeader.FK_PurchaseOrderHeader_Employee_EmployeeID
        public virtual SalesPerson SalesPerson { get; set; } // SalesPerson.FK_SalesPerson_Employee_BusinessEntityID

        // Foreign keys
        public virtual Person Person { get; set; } // FK_Employee_Person_BusinessEntityID

        public Employee()
        {
            SalariedFlag = true;
            VacationHours = 0;
            SickLeaveHours = 0;
            CurrentFlag = true;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Documents = new List<Document>();
            EmployeeDepartmentHistories = new List<EmployeeDepartmentHistory>();
            EmployeePayHistories = new List<EmployeePayHistory>();
            JobCandidates = new List<JobCandidate>();
            PurchaseOrderHeaders = new List<PurchaseOrderHeader>();
        }
    }

    // EmployeeDepartmentHistory
    public class EmployeeDepartmentHistory
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Employee identification number. Foreign key to Employee.BusinessEntityID.
        public short DepartmentId { get; set; } // DepartmentID (Primary key). Department in which the employee worked including currently. Foreign key to Department.DepartmentID.
        public byte ShiftId { get; set; } // ShiftID (Primary key). Identifies which 8-hour shift the employee works. Foreign key to Shift.Shift.ID.
        public DateTime StartDate { get; set; } // StartDate (Primary key). Date the employee started work in the department.
        public DateTime? EndDate { get; set; } // EndDate. Date the employee left the department. NULL = Current department.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Department Department { get; set; } // FK_EmployeeDepartmentHistory_Department_DepartmentID
        public virtual Employee Employee { get; set; } // FK_EmployeeDepartmentHistory_Employee_BusinessEntityID
        public virtual Shift Shift { get; set; } // FK_EmployeeDepartmentHistory_Shift_ShiftID

        public EmployeeDepartmentHistory()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // EmployeePayHistory
    public class EmployeePayHistory
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Employee identification number. Foreign key to Employee.BusinessEntityID.
        public DateTime RateChangeDate { get; set; } // RateChangeDate (Primary key). Date the change in pay is effective
        public decimal Rate { get; set; } // Rate. Salary hourly rate.
        public byte PayFrequency { get; set; } // PayFrequency. 1 = Salary received monthly, 2 = Salary received biweekly
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Employee Employee { get; set; } // FK_EmployeePayHistory_Employee_BusinessEntityID

        public EmployeePayHistory()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // Illustration
    public class Illustration
    {
        public int IllustrationId { get; set; } // IllustrationID (Primary key). Primary key for Illustration records.
        public string Diagram { get; set; } // Diagram. Illustrations used in manufacturing instructions. Stored as XML.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<ProductModelIllustration> ProductModelIllustrations { get; set; } // Many to many mapping

        public Illustration()
        {
            ModifiedDate = System.DateTime.Now;
            ProductModelIllustrations = new List<ProductModelIllustration>();
        }
    }

    // JobCandidate
    public class JobCandidate
    {
        public int JobCandidateId { get; set; } // JobCandidateID (Primary key). Primary key for JobCandidate records.
        public int? BusinessEntityId { get; set; } // BusinessEntityID. Employee identification number if applicant was hired. Foreign key to Employee.BusinessEntityID.
        public string Resume { get; set; } // Resume. Résumé in XML format.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Employee Employee { get; set; } // FK_JobCandidate_Employee_BusinessEntityID

        public JobCandidate()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // Location
    public class Location
    {
        public short LocationId { get; set; } // LocationID (Primary key). Primary key for Location records.
        public string Name { get; set; } // Name. Location description.
        public decimal CostRate { get; set; } // CostRate. Standard hourly cost of the manufacturing location.
        public decimal Availability { get; set; } // Availability. Work capacity (in hours) of the manufacturing location.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<ProductInventory> ProductInventories { get; set; } // Many to many mapping
        public virtual ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; } // WorkOrderRouting.FK_WorkOrderRouting_Location_LocationID

        public Location()
        {
            CostRate = 0.00m;
            Availability = 0.00m;
            ModifiedDate = System.DateTime.Now;
            ProductInventories = new List<ProductInventory>();
            WorkOrderRoutings = new List<WorkOrderRouting>();
        }
    }

    // Password
    public class Password
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)
        public string PasswordHash { get; set; } // PasswordHash. Password for the e-mail account.
        public string PasswordSalt { get; set; } // PasswordSalt. Random value concatenated with the password string before the password is hashed.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Person Person { get; set; } // FK_Password_Person_BusinessEntityID

        public Password()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

    // Person
    public class Person
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key for Person records.
        public string PersonType { get; set; } // PersonType. Primary type of person: SC = Store Contact, IN = Individual (retail) customer, SP = Sales person, EM = Employee (non-sales), VC = Vendor contact, GC = General contact
        public bool NameStyle { get; set; } // NameStyle. 0 = The data in FirstName and LastName are stored in western style (first name, last name) order.  1 = Eastern style (last name, first name) order.
        public string Title { get; set; } // Title. A courtesy title. For example, Mr. or Ms.
        public string FirstName { get; set; } // FirstName. First name of the person.
        public string MiddleName { get; set; } // MiddleName. Middle name or middle initial of the person.
        public string LastName { get; set; } // LastName. Last name of the person.
        public string Suffix { get; set; } // Suffix. Surname suffix. For example, Sr. or Jr.
        public int EmailPromotion { get; set; } // EmailPromotion. 0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorks, 2 = Contact does wish to receive e-mail promotions from AdventureWorks and selected partners.
        public string AdditionalContactInfo { get; set; } // AdditionalContactInfo. Additional contact information about the person stored in xml format.
        public string Demographics { get; set; } // Demographics. Personal information such as hobbies, and income collected from online shoppers. Used for sales analysis.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual Employee Employee { get; set; } // Employee.FK_Employee_Person_BusinessEntityID
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; } // Many to many mapping
        public virtual ICollection<Customer> Customers { get; set; } // Customer.FK_Customer_Person_PersonID
        public virtual ICollection<EmailAddress> EmailAddresses { get; set; } // Many to many mapping
        public virtual ICollection<PersonCreditCard> PersonCreditCards { get; set; } // Many to many mapping
        public virtual ICollection<PersonPhone> PersonPhones { get; set; } // Many to many mapping
        public virtual Password Password { get; set; } // Password.FK_Password_Person_BusinessEntityID

        // Foreign keys
        public virtual BusinessEntity BusinessEntity { get; set; } // FK_Person_BusinessEntity_BusinessEntityID

        public Person()
        {
            NameStyle = false;
            EmailPromotion = 0;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            BusinessEntityContacts = new List<BusinessEntityContact>();
            Customers = new List<Customer>();
            EmailAddresses = new List<EmailAddress>();
            PersonCreditCards = new List<PersonCreditCard>();
            PersonPhones = new List<PersonPhone>();
        }
    }

    // PersonCreditCard
    public class PersonCreditCard
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Business entity identification number. Foreign key to Person.BusinessEntityID.
        public int CreditCardId { get; set; } // CreditCardID (Primary key). Credit card identification number. Foreign key to CreditCard.CreditCardID.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual CreditCard CreditCard { get; set; } // FK_PersonCreditCard_CreditCard_CreditCardID
        public virtual Person Person { get; set; } // FK_PersonCreditCard_Person_BusinessEntityID

        public PersonCreditCard()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // PersonPhone
    public class PersonPhone
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Business entity identification number. Foreign key to Person.BusinessEntityID.
        public string PhoneNumber { get; set; } // PhoneNumber (Primary key). Telephone number identification number.
        public int PhoneNumberTypeId { get; set; } // PhoneNumberTypeID (Primary key). Kind of phone number. Foreign key to PhoneNumberType.PhoneNumberTypeID.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Person Person { get; set; } // FK_PersonPhone_Person_BusinessEntityID
        public virtual PhoneNumberType PhoneNumberType { get; set; } // FK_PersonPhone_PhoneNumberType_PhoneNumberTypeID

        public PersonPhone()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // PhoneNumberType
    public class PhoneNumberType
    {
        public int PhoneNumberTypeId { get; set; } // PhoneNumberTypeID (Primary key). Primary key for telephone number type records.
        public string Name { get; set; } // Name. Name of the telephone number type
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<PersonPhone> PersonPhones { get; set; } // Many to many mapping

        public PhoneNumberType()
        {
            ModifiedDate = System.DateTime.Now;
            PersonPhones = new List<PersonPhone>();
        }
    }

    // Product
    public class Product
    {
        public int ProductId { get; set; } // ProductID (Primary key). Primary key for Product records.
        public string Name { get; set; } // Name. Name of the product.
        public string ProductNumber { get; set; } // ProductNumber. Unique product identification number.
        public bool MakeFlag { get; set; } // MakeFlag. 0 = Product is purchased, 1 = Product is manufactured in-house.
        public bool FinishedGoodsFlag { get; set; } // FinishedGoodsFlag. 0 = Product is not a salable item. 1 = Product is salable.
        public string Color { get; set; } // Color. Product color.
        public short SafetyStockLevel { get; set; } // SafetyStockLevel. Minimum inventory quantity.
        public short ReorderPoint { get; set; } // ReorderPoint. Inventory level that triggers a purchase order or work order.
        public decimal StandardCost { get; set; } // StandardCost. Standard cost of the product.
        public decimal ListPrice { get; set; } // ListPrice. Selling price.
        public string Size { get; set; } // Size. Product size.
        public string SizeUnitMeasureCode { get; set; } // SizeUnitMeasureCode. Unit of measure for Size column.
        public string WeightUnitMeasureCode { get; set; } // WeightUnitMeasureCode. Unit of measure for Weight column.
        public decimal? Weight { get; set; } // Weight. Product weight.
        public int DaysToManufacture { get; set; } // DaysToManufacture. Number of days required to manufacture the product.
        public string ProductLine { get; set; } // ProductLine. R = Road, M = Mountain, T = Touring, S = Standard
        public string Class { get; set; } // Class. H = High, M = Medium, L = Low
        public string Style { get; set; } // Style. W = Womens, M = Mens, U = Universal
        public int? ProductSubcategoryId { get; set; } // ProductSubcategoryID. Product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID.
        public int? ProductModelId { get; set; } // ProductModelID. Product is a member of this product model. Foreign key to ProductModel.ProductModelID.
        public DateTime SellStartDate { get; set; } // SellStartDate. Date the product was available for sale.
        public DateTime? SellEndDate { get; set; } // SellEndDate. Date the product was no longer available for sale.
        public DateTime? DiscontinuedDate { get; set; } // DiscontinuedDate. Date the product was discontinued.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<BillOfMaterial> BillOfMaterials_ComponentId { get; set; } // BillOfMaterials.FK_BillOfMaterials_Product_ComponentID
        public virtual ICollection<BillOfMaterial> BillOfMaterials_ProductAssemblyId { get; set; } // BillOfMaterials.FK_BillOfMaterials_Product_ProductAssemblyID
        public virtual ICollection<ProductCostHistory> ProductCostHistories { get; set; } // Many to many mapping
        public virtual ICollection<ProductDocument> ProductDocuments { get; set; } // Many to many mapping
        public virtual ICollection<ProductInventory> ProductInventories { get; set; } // Many to many mapping
        public virtual ICollection<ProductListPriceHistory> ProductListPriceHistories { get; set; } // Many to many mapping
        public virtual ICollection<ProductProductPhoto> ProductProductPhotoes { get; set; } // Many to many mapping
        public virtual ICollection<ProductReview> ProductReviews { get; set; } // ProductReview.FK_ProductReview_Product_ProductID
        public virtual ICollection<ProductVendor> ProductVendors { get; set; } // Many to many mapping
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; } // PurchaseOrderDetail.FK_PurchaseOrderDetail_Product_ProductID
        public virtual ICollection<ShoppingCartItem> ShoppingCartItems { get; set; } // ShoppingCartItem.FK_ShoppingCartItem_Product_ProductID
        public virtual ICollection<SpecialOfferProduct> SpecialOfferProducts { get; set; } // Many to many mapping
        public virtual ICollection<TransactionHistory> TransactionHistories { get; set; } // TransactionHistory.FK_TransactionHistory_Product_ProductID
        public virtual ICollection<WorkOrder> WorkOrders { get; set; } // WorkOrder.FK_WorkOrder_Product_ProductID

        // Foreign keys
        public virtual ProductModel ProductModel { get; set; } // FK_Product_ProductModel_ProductModelID
        public virtual ProductSubcategory ProductSubcategory { get; set; } // FK_Product_ProductSubcategory_ProductSubcategoryID
        public virtual UnitMeasure UnitMeasure_SizeUnitMeasureCode { get; set; } // FK_Product_UnitMeasure_SizeUnitMeasureCode
        public virtual UnitMeasure UnitMeasure_WeightUnitMeasureCode { get; set; } // FK_Product_UnitMeasure_WeightUnitMeasureCode

        public Product()
        {
            MakeFlag = true;
            FinishedGoodsFlag = true;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            BillOfMaterials_ComponentId = new List<BillOfMaterial>();
            BillOfMaterials_ProductAssemblyId = new List<BillOfMaterial>();
            ProductCostHistories = new List<ProductCostHistory>();
            ProductDocuments = new List<ProductDocument>();
            ProductInventories = new List<ProductInventory>();
            ProductListPriceHistories = new List<ProductListPriceHistory>();
            ProductProductPhotoes = new List<ProductProductPhoto>();
            ProductReviews = new List<ProductReview>();
            ProductVendors = new List<ProductVendor>();
            PurchaseOrderDetails = new List<PurchaseOrderDetail>();
            ShoppingCartItems = new List<ShoppingCartItem>();
            SpecialOfferProducts = new List<SpecialOfferProduct>();
            TransactionHistories = new List<TransactionHistory>();
            WorkOrders = new List<WorkOrder>();
        }
    }

    // ProductCategory
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; } // ProductCategoryID (Primary key). Primary key for ProductCategory records.
        public string Name { get; set; } // Name. Category description.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<ProductSubcategory> ProductSubcategories { get; set; } // ProductSubcategory.FK_ProductSubcategory_ProductCategory_ProductCategoryID

        public ProductCategory()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            ProductSubcategories = new List<ProductSubcategory>();
        }
    }

    // ProductCostHistory
    public class ProductCostHistory
    {
        public int ProductId { get; set; } // ProductID (Primary key). Product identification number. Foreign key to Product.ProductID
        public DateTime StartDate { get; set; } // StartDate (Primary key). Product cost start date.
        public DateTime? EndDate { get; set; } // EndDate. Product cost end date.
        public decimal StandardCost { get; set; } // StandardCost. Standard cost of the product.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Product Product { get; set; } // FK_ProductCostHistory_Product_ProductID

        public ProductCostHistory()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // ProductDescription
    public class ProductDescription
    {
        public int ProductDescriptionId { get; set; } // ProductDescriptionID (Primary key). Primary key for ProductDescription records.
        public string Description { get; set; } // Description. Description of the product.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; } // Many to many mapping

        public ProductDescription()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            ProductModelProductDescriptionCultures = new List<ProductModelProductDescriptionCulture>();
        }
    }

    // ProductDocument
    public class ProductDocument
    {
        public int ProductId { get; set; } // ProductID (Primary key). Product identification number. Foreign key to Product.ProductID.
        public string DocumentNode { get; set; } // DocumentNode (Primary key). Document identification number. Foreign key to Document.DocumentNode.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Document Document { get; set; } // FK_ProductDocument_Document_DocumentNode
        public virtual Product Product { get; set; } // FK_ProductDocument_Product_ProductID

        public ProductDocument()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // ProductInventory
    public class ProductInventory
    {
        public int ProductId { get; set; } // ProductID (Primary key). Product identification number. Foreign key to Product.ProductID.
        public short LocationId { get; set; } // LocationID (Primary key). Inventory location identification number. Foreign key to Location.LocationID.
        public string Shelf { get; set; } // Shelf. Storage compartment within an inventory location.
        public byte Bin { get; set; } // Bin. Storage container on a shelf in an inventory location.
        public short Quantity { get; set; } // Quantity. Quantity of products in the inventory location.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Location Location { get; set; } // FK_ProductInventory_Location_LocationID
        public virtual Product Product { get; set; } // FK_ProductInventory_Product_ProductID

        public ProductInventory()
        {
            Quantity = 0;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

    // ProductListPriceHistory
    public class ProductListPriceHistory
    {
        public int ProductId { get; set; } // ProductID (Primary key). Product identification number. Foreign key to Product.ProductID
        public DateTime StartDate { get; set; } // StartDate (Primary key). List price start date.
        public DateTime? EndDate { get; set; } // EndDate. List price end date
        public decimal ListPrice { get; set; } // ListPrice. Product list price.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Product Product { get; set; } // FK_ProductListPriceHistory_Product_ProductID

        public ProductListPriceHistory()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // ProductModel
    public class ProductModel
    {
        public int ProductModelId { get; set; } // ProductModelID (Primary key). Primary key for ProductModel records.
        public string Name { get; set; } // Name. Product model description.
        public string CatalogDescription { get; set; } // CatalogDescription. Detailed product catalog information in xml format.
        public string Instructions { get; set; } // Instructions. Manufacturing instructions in xml format.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Product> Products { get; set; } // Product.FK_Product_ProductModel_ProductModelID
        public virtual ICollection<ProductModelIllustration> ProductModelIllustrations { get; set; } // Many to many mapping
        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; } // Many to many mapping

        public ProductModel()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Products = new List<Product>();
            ProductModelIllustrations = new List<ProductModelIllustration>();
            ProductModelProductDescriptionCultures = new List<ProductModelProductDescriptionCulture>();
        }
    }

    // ProductModelIllustration
    public class ProductModelIllustration
    {
        public int ProductModelId { get; set; } // ProductModelID (Primary key). Primary key. Foreign key to ProductModel.ProductModelID.
        public int IllustrationId { get; set; } // IllustrationID (Primary key). Primary key. Foreign key to Illustration.IllustrationID.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Illustration Illustration { get; set; } // FK_ProductModelIllustration_Illustration_IllustrationID
        public virtual ProductModel ProductModel { get; set; } // FK_ProductModelIllustration_ProductModel_ProductModelID

        public ProductModelIllustration()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // ProductModelProductDescriptionCulture
    public class ProductModelProductDescriptionCulture
    {
        public int ProductModelId { get; set; } // ProductModelID (Primary key). Primary key. Foreign key to ProductModel.ProductModelID.
        public int ProductDescriptionId { get; set; } // ProductDescriptionID (Primary key). Primary key. Foreign key to ProductDescription.ProductDescriptionID.
        public string CultureId { get; set; } // CultureID (Primary key). Culture identification number. Foreign key to Culture.CultureID.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Culture Culture { get; set; } // FK_ProductModelProductDescriptionCulture_Culture_CultureID
        public virtual ProductDescription ProductDescription { get; set; } // FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID
        public virtual ProductModel ProductModel { get; set; } // FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID

        public ProductModelProductDescriptionCulture()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // ProductPhoto
    public class ProductPhoto
    {
        public int ProductPhotoId { get; set; } // ProductPhotoID (Primary key). Primary key for ProductPhoto records.
        public byte[] ThumbNailPhoto { get; set; } // ThumbNailPhoto. Small image of the product.
        public string ThumbnailPhotoFileName { get; set; } // ThumbnailPhotoFileName. Small image file name.
        public byte[] LargePhoto { get; set; } // LargePhoto. Large image of the product.
        public string LargePhotoFileName { get; set; } // LargePhotoFileName. Large image file name.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<ProductProductPhoto> ProductProductPhotoes { get; set; } // Many to many mapping

        public ProductPhoto()
        {
            ModifiedDate = System.DateTime.Now;
            ProductProductPhotoes = new List<ProductProductPhoto>();
        }
    }

    // ProductProductPhoto
    public class ProductProductPhoto
    {
        public int ProductId { get; set; } // ProductID (Primary key). Product identification number. Foreign key to Product.ProductID.
        public int ProductPhotoId { get; set; } // ProductPhotoID (Primary key). Product photo identification number. Foreign key to ProductPhoto.ProductPhotoID.
        public bool Primary { get; set; } // Primary. 0 = Photo is not the principal image. 1 = Photo is the principal image.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Product Product { get; set; } // FK_ProductProductPhoto_Product_ProductID
        public virtual ProductPhoto ProductPhoto { get; set; } // FK_ProductProductPhoto_ProductPhoto_ProductPhotoID

        public ProductProductPhoto()
        {
            Primary = false;
            ModifiedDate = System.DateTime.Now;
        }
    }

    // ProductReview
    public class ProductReview
    {
        public int ProductReviewId { get; set; } // ProductReviewID (Primary key). Primary key for ProductReview records.
        public int ProductId { get; set; } // ProductID. Product identification number. Foreign key to Product.ProductID.
        public string ReviewerName { get; set; } // ReviewerName. Name of the reviewer.
        public DateTime ReviewDate { get; set; } // ReviewDate. Date review was submitted.
        public string EmailAddress { get; set; } // EmailAddress. Reviewer's e-mail address.
        public int Rating { get; set; } // Rating. Product rating given by the reviewer. Scale is 1 to 5 with 5 as the highest rating.
        public string Comments { get; set; } // Comments. Reviewer's comments
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Product Product { get; set; } // FK_ProductReview_Product_ProductID

        public ProductReview()
        {
            ReviewDate = System.DateTime.Now;
            ModifiedDate = System.DateTime.Now;
        }
    }

    // ProductSubcategory
    public class ProductSubcategory
    {
        public int ProductSubcategoryId { get; set; } // ProductSubcategoryID (Primary key). Primary key for ProductSubcategory records.
        public int ProductCategoryId { get; set; } // ProductCategoryID. Product category identification number. Foreign key to ProductCategory.ProductCategoryID.
        public string Name { get; set; } // Name. Subcategory description.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Product> Products { get; set; } // Product.FK_Product_ProductSubcategory_ProductSubcategoryID

        // Foreign keys
        public virtual ProductCategory ProductCategory { get; set; } // FK_ProductSubcategory_ProductCategory_ProductCategoryID

        public ProductSubcategory()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Products = new List<Product>();
        }
    }

    // ProductVendor
    public class ProductVendor
    {
        public int ProductId { get; set; } // ProductID (Primary key). Primary key. Foreign key to Product.ProductID.
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key. Foreign key to Vendor.BusinessEntityID.
        public int AverageLeadTime { get; set; } // AverageLeadTime. The average span of time (in days) between placing an order with the vendor and receiving the purchased product.
        public decimal StandardPrice { get; set; } // StandardPrice. The vendor's usual selling price.
        public decimal? LastReceiptCost { get; set; } // LastReceiptCost. The selling price when last purchased.
        public DateTime? LastReceiptDate { get; set; } // LastReceiptDate. Date the product was last received by the vendor.
        public int MinOrderQty { get; set; } // MinOrderQty. The maximum quantity that should be ordered.
        public int MaxOrderQty { get; set; } // MaxOrderQty. The minimum quantity that should be ordered.
        public int? OnOrderQty { get; set; } // OnOrderQty. The quantity currently on order.
        public string UnitMeasureCode { get; set; } // UnitMeasureCode. The product's unit of measure.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Product Product { get; set; } // FK_ProductVendor_Product_ProductID
        public virtual UnitMeasure UnitMeasure { get; set; } // FK_ProductVendor_UnitMeasure_UnitMeasureCode
        public virtual Vendor Vendor { get; set; } // FK_ProductVendor_Vendor_BusinessEntityID

        public ProductVendor()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // PurchaseOrderDetail
    public class PurchaseOrderDetail
    {
        public int PurchaseOrderId { get; set; } // PurchaseOrderID (Primary key). Primary key. Foreign key to PurchaseOrderHeader.PurchaseOrderID.
        public int PurchaseOrderDetailId { get; set; } // PurchaseOrderDetailID (Primary key). Primary key. One line number per purchased product.
        public DateTime DueDate { get; set; } // DueDate. Date the product is expected to be received.
        public short OrderQty { get; set; } // OrderQty. Quantity ordered.
        public int ProductId { get; set; } // ProductID. Product identification number. Foreign key to Product.ProductID.
        public decimal UnitPrice { get; set; } // UnitPrice. Vendor's selling price of a single product.
        public decimal LineTotal { get; internal set; } // LineTotal. Per product subtotal. Computed as OrderQty * UnitPrice.
        public decimal ReceivedQty { get; set; } // ReceivedQty. Quantity actually received from the vendor.
        public decimal RejectedQty { get; set; } // RejectedQty. Quantity rejected during inspection.
        public decimal StockedQty { get; internal set; } // StockedQty. Quantity accepted into inventory. Computed as ReceivedQty - RejectedQty.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Product Product { get; set; } // FK_PurchaseOrderDetail_Product_ProductID
        public virtual PurchaseOrderHeader PurchaseOrderHeader { get; set; } // FK_PurchaseOrderDetail_PurchaseOrderHeader_PurchaseOrderID

        public PurchaseOrderDetail()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // PurchaseOrderHeader
    public class PurchaseOrderHeader
    {
        public int PurchaseOrderId { get; set; } // PurchaseOrderID (Primary key). Primary key.
        public byte RevisionNumber { get; set; } // RevisionNumber. Incremental number to track changes to the purchase order over time.
        public byte Status { get; set; } // Status. Order current status. 1 = Pending; 2 = Approved; 3 = Rejected; 4 = Complete
        public int EmployeeId { get; set; } // EmployeeID. Employee who created the purchase order. Foreign key to Employee.BusinessEntityID.
        public int VendorId { get; set; } // VendorID. Vendor with whom the purchase order is placed. Foreign key to Vendor.BusinessEntityID.
        public int ShipMethodId { get; set; } // ShipMethodID. Shipping method. Foreign key to ShipMethod.ShipMethodID.
        public DateTime OrderDate { get; set; } // OrderDate. Purchase order creation date.
        public DateTime? ShipDate { get; set; } // ShipDate. Estimated shipment date from the vendor.
        public decimal SubTotal { get; set; } // SubTotal. Purchase order subtotal. Computed as SUM(PurchaseOrderDetail.LineTotal)for the appropriate PurchaseOrderID.
        public decimal TaxAmt { get; set; } // TaxAmt. Tax amount.
        public decimal Freight { get; set; } // Freight. Shipping cost.
        public decimal TotalDue { get; internal set; } // TotalDue. Total due to vendor. Computed as Subtotal + TaxAmt + Freight.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; } // Many to many mapping

        // Foreign keys
        public virtual Employee Employee { get; set; } // FK_PurchaseOrderHeader_Employee_EmployeeID
        public virtual ShipMethod ShipMethod { get; set; } // FK_PurchaseOrderHeader_ShipMethod_ShipMethodID
        public virtual Vendor Vendor { get; set; } // FK_PurchaseOrderHeader_Vendor_VendorID

        public PurchaseOrderHeader()
        {
            RevisionNumber = 0;
            Status = 1;
            OrderDate = System.DateTime.Now;
            SubTotal = 0.00m;
            TaxAmt = 0.00m;
            Freight = 0.00m;
            ModifiedDate = System.DateTime.Now;
            PurchaseOrderDetails = new List<PurchaseOrderDetail>();
        }
    }

    // SalesOrderDetail
    public class SalesOrderDetail
    {
        public int SalesOrderId { get; set; } // SalesOrderID (Primary key). Primary key. Foreign key to SalesOrderHeader.SalesOrderID.
        public int SalesOrderDetailId { get; set; } // SalesOrderDetailID (Primary key). Primary key. One incremental unique number per product sold.
        public string CarrierTrackingNumber { get; set; } // CarrierTrackingNumber. Shipment tracking number supplied by the shipper.
        public short OrderQty { get; set; } // OrderQty. Quantity ordered per product.
        public int ProductId { get; set; } // ProductID. Product sold to customer. Foreign key to Product.ProductID.
        public int SpecialOfferId { get; set; } // SpecialOfferID. Promotional code. Foreign key to SpecialOffer.SpecialOfferID.
        public decimal UnitPrice { get; set; } // UnitPrice. Selling price of a single product.
        public decimal UnitPriceDiscount { get; set; } // UnitPriceDiscount. Discount amount.
        public decimal LineTotal { get; internal set; } // LineTotal. Per product subtotal. Computed as UnitPrice * (1 - UnitPriceDiscount) * OrderQty.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual SalesOrderHeader SalesOrderHeader { get; set; } // FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID
        public virtual SpecialOfferProduct SpecialOfferProduct { get; set; } // FK_SalesOrderDetail_SpecialOfferProduct_SpecialOfferIDProductID

        public SalesOrderDetail()
        {
            UnitPriceDiscount = 0.0m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

    // SalesOrderHeader
    public class SalesOrderHeader
    {
        public int SalesOrderId { get; set; } // SalesOrderID (Primary key). Primary key.
        public byte RevisionNumber { get; set; } // RevisionNumber. Incremental number to track changes to the sales order over time.
        public DateTime OrderDate { get; set; } // OrderDate. Dates the sales order was created.
        public DateTime DueDate { get; set; } // DueDate. Date the order is due to the customer.
        public DateTime? ShipDate { get; set; } // ShipDate. Date the order was shipped to the customer.
        public byte Status { get; set; } // Status. Order current status. 1 = In process; 2 = Approved; 3 = Backordered; 4 = Rejected; 5 = Shipped; 6 = Cancelled
        public bool OnlineOrderFlag { get; set; } // OnlineOrderFlag. 0 = Order placed by sales person. 1 = Order placed online by customer.
        public string SalesOrderNumber { get; internal set; } // SalesOrderNumber. Unique sales order identification number.
        public string PurchaseOrderNumber { get; set; } // PurchaseOrderNumber. Customer purchase order number reference.
        public string AccountNumber { get; set; } // AccountNumber. Financial accounting number reference.
        public int CustomerId { get; set; } // CustomerID. Customer identification number. Foreign key to Customer.BusinessEntityID.
        public int? SalesPersonId { get; set; } // SalesPersonID. Sales person who created the sales order. Foreign key to SalesPerson.BusinessEntityID.
        public int? TerritoryId { get; set; } // TerritoryID. Territory in which the sale was made. Foreign key to SalesTerritory.SalesTerritoryID.
        public int BillToAddressId { get; set; } // BillToAddressID. Customer billing address. Foreign key to Address.AddressID.
        public int ShipToAddressId { get; set; } // ShipToAddressID. Customer shipping address. Foreign key to Address.AddressID.
        public int ShipMethodId { get; set; } // ShipMethodID. Shipping method. Foreign key to ShipMethod.ShipMethodID.
        public int? CreditCardId { get; set; } // CreditCardID. Credit card identification number. Foreign key to CreditCard.CreditCardID.
        public string CreditCardApprovalCode { get; set; } // CreditCardApprovalCode. Approval code provided by the credit card company.
        public int? CurrencyRateId { get; set; } // CurrencyRateID. Currency exchange rate used. Foreign key to CurrencyRate.CurrencyRateID.
        public decimal SubTotal { get; set; } // SubTotal. Sales subtotal. Computed as SUM(SalesOrderDetail.LineTotal)for the appropriate SalesOrderID.
        public decimal TaxAmt { get; set; } // TaxAmt. Tax amount.
        public decimal Freight { get; set; } // Freight. Shipping cost.
        public decimal TotalDue { get; internal set; } // TotalDue. Total due from customer. Computed as Subtotal + TaxAmt + Freight.
        public string Comment { get; set; } // Comment. Sales representative comments.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; } // Many to many mapping
        public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; } // Many to many mapping

        // Foreign keys
        public virtual Address Address_BillToAddressId { get; set; } // FK_SalesOrderHeader_Address_BillToAddressID
        public virtual Address Address_ShipToAddressId { get; set; } // FK_SalesOrderHeader_Address_ShipToAddressID
        public virtual CreditCard CreditCard { get; set; } // FK_SalesOrderHeader_CreditCard_CreditCardID
        public virtual CurrencyRate CurrencyRate { get; set; } // FK_SalesOrderHeader_CurrencyRate_CurrencyRateID
        public virtual Customer Customer { get; set; } // FK_SalesOrderHeader_Customer_CustomerID
        public virtual SalesPerson SalesPerson { get; set; } // FK_SalesOrderHeader_SalesPerson_SalesPersonID
        public virtual SalesTerritory SalesTerritory { get; set; } // FK_SalesOrderHeader_SalesTerritory_TerritoryID
        public virtual ShipMethod ShipMethod { get; set; } // FK_SalesOrderHeader_ShipMethod_ShipMethodID

        public SalesOrderHeader()
        {
            RevisionNumber = 0;
            OrderDate = System.DateTime.Now;
            Status = 1;
            OnlineOrderFlag = true;
            SubTotal = 0.00m;
            TaxAmt = 0.00m;
            Freight = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            SalesOrderDetails = new List<SalesOrderDetail>();
            SalesOrderHeaderSalesReasons = new List<SalesOrderHeaderSalesReason>();
        }
    }

    // SalesOrderHeaderSalesReason
    public class SalesOrderHeaderSalesReason
    {
        public int SalesOrderId { get; set; } // SalesOrderID (Primary key). Primary key. Foreign key to SalesOrderHeader.SalesOrderID.
        public int SalesReasonId { get; set; } // SalesReasonID (Primary key). Primary key. Foreign key to SalesReason.SalesReasonID.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual SalesOrderHeader SalesOrderHeader { get; set; } // FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderID
        public virtual SalesReason SalesReason { get; set; } // FK_SalesOrderHeaderSalesReason_SalesReason_SalesReasonID

        public SalesOrderHeaderSalesReason()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // SalesPerson
    public class SalesPerson
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key for SalesPerson records. Foreign key to Employee.BusinessEntityID
        public int? TerritoryId { get; set; } // TerritoryID. Territory currently assigned to. Foreign key to SalesTerritory.SalesTerritoryID.
        public decimal? SalesQuota { get; set; } // SalesQuota. Projected yearly sales.
        public decimal Bonus { get; set; } // Bonus. Bonus due if quota is met.
        public decimal CommissionPct { get; set; } // CommissionPct. Commision percent received per sale.
        public decimal SalesYtd { get; set; } // SalesYTD. Sales total year to date.
        public decimal SalesLastYear { get; set; } // SalesLastYear. Sales total of previous year.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_SalesPerson_SalesPersonID
        public virtual ICollection<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; } // Many to many mapping
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; } // Many to many mapping
        public virtual ICollection<Store> Stores { get; set; } // Store.FK_Store_SalesPerson_SalesPersonID

        // Foreign keys
        public virtual Employee Employee { get; set; } // FK_SalesPerson_Employee_BusinessEntityID
        public virtual SalesTerritory SalesTerritory { get; set; } // FK_SalesPerson_SalesTerritory_TerritoryID

        public SalesPerson()
        {
            Bonus = 0.00m;
            CommissionPct = 0.00m;
            SalesYtd = 0.00m;
            SalesLastYear = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            SalesOrderHeaders = new List<SalesOrderHeader>();
            SalesPersonQuotaHistories = new List<SalesPersonQuotaHistory>();
            SalesTerritoryHistories = new List<SalesTerritoryHistory>();
            Stores = new List<Store>();
        }
    }

    // SalesPersonQuotaHistory
    public class SalesPersonQuotaHistory
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Sales person identification number. Foreign key to SalesPerson.BusinessEntityID.
        public DateTime QuotaDate { get; set; } // QuotaDate (Primary key). Sales quota date.
        public decimal SalesQuota { get; set; } // SalesQuota. Sales quota amount.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual SalesPerson SalesPerson { get; set; } // FK_SalesPersonQuotaHistory_SalesPerson_BusinessEntityID

        public SalesPersonQuotaHistory()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

    // SalesReason
    public class SalesReason
    {
        public int SalesReasonId { get; set; } // SalesReasonID (Primary key). Primary key for SalesReason records.
        public string Name { get; set; } // Name. Sales reason description.
        public string ReasonType { get; set; } // ReasonType. Category the sales reason belongs to.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; } // Many to many mapping

        public SalesReason()
        {
            ModifiedDate = System.DateTime.Now;
            SalesOrderHeaderSalesReasons = new List<SalesOrderHeaderSalesReason>();
        }
    }

    // SalesTaxRate
    public class SalesTaxRate
    {
        public int SalesTaxRateId { get; set; } // SalesTaxRateID (Primary key). Primary key for SalesTaxRate records.
        public int StateProvinceId { get; set; } // StateProvinceID. State, province, or country/region the sales tax applies to.
        public byte TaxType { get; set; } // TaxType. 1 = Tax applied to retail transactions, 2 = Tax applied to wholesale transactions, 3 = Tax applied to all sales (retail and wholesale) transactions.
        public decimal TaxRate { get; set; } // TaxRate. Tax rate amount.
        public string Name { get; set; } // Name. Tax rate description.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual StateProvince StateProvince { get; set; } // FK_SalesTaxRate_StateProvince_StateProvinceID

        public SalesTaxRate()
        {
            TaxRate = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

    // SalesTerritory
    public class SalesTerritory
    {
        public int TerritoryId { get; set; } // TerritoryID (Primary key). Primary key for SalesTerritory records.
        public string Name { get; set; } // Name. Sales territory description
        public string CountryRegionCode { get; set; } // CountryRegionCode. ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode.
        public string Group { get; set; } // Group. Geographic area to which the sales territory belong.
        public decimal SalesYtd { get; set; } // SalesYTD. Sales in the territory year to date.
        public decimal SalesLastYear { get; set; } // SalesLastYear. Sales in the territory the previous year.
        public decimal CostYtd { get; set; } // CostYTD. Business costs in the territory year to date.
        public decimal CostLastYear { get; set; } // CostLastYear. Business costs in the territory the previous year.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Customer> Customers { get; set; } // Customer.FK_Customer_SalesTerritory_TerritoryID
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_SalesTerritory_TerritoryID
        public virtual ICollection<SalesPerson> SalesPersons { get; set; } // SalesPerson.FK_SalesPerson_SalesTerritory_TerritoryID
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; } // Many to many mapping
        public virtual ICollection<StateProvince> StateProvinces { get; set; } // StateProvince.FK_StateProvince_SalesTerritory_TerritoryID

        // Foreign keys
        public virtual CountryRegion CountryRegion { get; set; } // FK_SalesTerritory_CountryRegion_CountryRegionCode

        public SalesTerritory()
        {
            SalesYtd = 0.00m;
            SalesLastYear = 0.00m;
            CostYtd = 0.00m;
            CostLastYear = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Customers = new List<Customer>();
            SalesOrderHeaders = new List<SalesOrderHeader>();
            SalesPersons = new List<SalesPerson>();
            SalesTerritoryHistories = new List<SalesTerritoryHistory>();
            StateProvinces = new List<StateProvince>();
        }
    }

    // SalesTerritoryHistory
    public class SalesTerritoryHistory
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key. The sales rep.  Foreign key to SalesPerson.BusinessEntityID.
        public int TerritoryId { get; set; } // TerritoryID (Primary key). Primary key. Territory identification number. Foreign key to SalesTerritory.SalesTerritoryID.
        public DateTime StartDate { get; set; } // StartDate (Primary key). Primary key. Date the sales representive started work in the territory.
        public DateTime? EndDate { get; set; } // EndDate. Date the sales representative left work in the territory.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual SalesPerson SalesPerson { get; set; } // FK_SalesTerritoryHistory_SalesPerson_BusinessEntityID
        public virtual SalesTerritory SalesTerritory { get; set; } // FK_SalesTerritoryHistory_SalesTerritory_TerritoryID

        public SalesTerritoryHistory()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

    // ScrapReason
    public class ScrapReason
    {
        public short ScrapReasonId { get; set; } // ScrapReasonID (Primary key). Primary key for ScrapReason records.
        public string Name { get; set; } // Name. Failure description.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<WorkOrder> WorkOrders { get; set; } // WorkOrder.FK_WorkOrder_ScrapReason_ScrapReasonID

        public ScrapReason()
        {
            ModifiedDate = System.DateTime.Now;
            WorkOrders = new List<WorkOrder>();
        }
    }

    // Shift
    public class Shift
    {
        public byte ShiftId { get; set; } // ShiftID (Primary key). Primary key for Shift records.
        public string Name { get; set; } // Name. Shift description.
        public TimeSpan StartTime { get; set; } // StartTime. Shift start time.
        public TimeSpan EndTime { get; set; } // EndTime. Shift end time.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; } // Many to many mapping

        public Shift()
        {
            ModifiedDate = System.DateTime.Now;
            EmployeeDepartmentHistories = new List<EmployeeDepartmentHistory>();
        }
    }

    // ShipMethod
    public class ShipMethod
    {
        public int ShipMethodId { get; set; } // ShipMethodID (Primary key). Primary key for ShipMethod records.
        public string Name { get; set; } // Name. Shipping company name.
        public decimal ShipBase { get; set; } // ShipBase. Minimum shipping charge.
        public decimal ShipRate { get; set; } // ShipRate. Shipping charge per pound.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; } // PurchaseOrderHeader.FK_PurchaseOrderHeader_ShipMethod_ShipMethodID
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_ShipMethod_ShipMethodID

        public ShipMethod()
        {
            ShipBase = 0.00m;
            ShipRate = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            PurchaseOrderHeaders = new List<PurchaseOrderHeader>();
            SalesOrderHeaders = new List<SalesOrderHeader>();
        }
    }

    // ShoppingCartItem
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; } // ShoppingCartItemID (Primary key). Primary key for ShoppingCartItem records.
        public string ShoppingCartId { get; set; } // ShoppingCartID. Shopping cart identification number.
        public int Quantity { get; set; } // Quantity. Product quantity ordered.
        public int ProductId { get; set; } // ProductID. Product ordered. Foreign key to Product.ProductID.
        public DateTime DateCreated { get; set; } // DateCreated. Date the time the record was created.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Product Product { get; set; } // FK_ShoppingCartItem_Product_ProductID

        public ShoppingCartItem()
        {
            Quantity = 1;
            DateCreated = System.DateTime.Now;
            ModifiedDate = System.DateTime.Now;
        }
    }

    // SpecialOffer
    public class SpecialOffer
    {
        public int SpecialOfferId { get; set; } // SpecialOfferID (Primary key). Primary key for SpecialOffer records.
        public string Description { get; set; } // Description. Discount description.
        public decimal DiscountPct { get; set; } // DiscountPct. Discount precentage.
        public string Type { get; set; } // Type. Discount type category.
        public string Category { get; set; } // Category. Group the discount applies to such as Reseller or Customer.
        public DateTime StartDate { get; set; } // StartDate. Discount start date.
        public DateTime EndDate { get; set; } // EndDate. Discount end date.
        public int MinQty { get; set; } // MinQty. Minimum discount percent allowed.
        public int? MaxQty { get; set; } // MaxQty. Maximum discount percent allowed.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<SpecialOfferProduct> SpecialOfferProducts { get; set; } // Many to many mapping

        public SpecialOffer()
        {
            DiscountPct = 0.00m;
            MinQty = 0;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            SpecialOfferProducts = new List<SpecialOfferProduct>();
        }
    }

    // SpecialOfferProduct
    public class SpecialOfferProduct
    {
        public int SpecialOfferId { get; set; } // SpecialOfferID (Primary key). Primary key for SpecialOfferProduct records.
        public int ProductId { get; set; } // ProductID (Primary key). Product identification number. Foreign key to Product.ProductID.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; } // Many to many mapping

        // Foreign keys
        public virtual Product Product { get; set; } // FK_SpecialOfferProduct_Product_ProductID
        public virtual SpecialOffer SpecialOffer { get; set; } // FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID

        public SpecialOfferProduct()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            SalesOrderDetails = new List<SalesOrderDetail>();
        }
    }

    // StateProvince
    public class StateProvince
    {
        public int StateProvinceId { get; set; } // StateProvinceID (Primary key). Primary key for StateProvince records.
        public string StateProvinceCode { get; set; } // StateProvinceCode. ISO standard state or province code.
        public string CountryRegionCode { get; set; } // CountryRegionCode. ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode.
        public bool IsOnlyStateProvinceFlag { get; set; } // IsOnlyStateProvinceFlag. 0 = StateProvinceCode exists. 1 = StateProvinceCode unavailable, using CountryRegionCode.
        public string Name { get; set; } // Name. State or province description.
        public int TerritoryId { get; set; } // TerritoryID. ID of the territory in which the state or province is located. Foreign key to SalesTerritory.SalesTerritoryID.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Address> Addresses { get; set; } // Address.FK_Address_StateProvince_StateProvinceID
        public virtual ICollection<SalesTaxRate> SalesTaxRates { get; set; } // SalesTaxRate.FK_SalesTaxRate_StateProvince_StateProvinceID

        // Foreign keys
        public virtual CountryRegion CountryRegion { get; set; } // FK_StateProvince_CountryRegion_CountryRegionCode
        public virtual SalesTerritory SalesTerritory { get; set; } // FK_StateProvince_SalesTerritory_TerritoryID

        public StateProvince()
        {
            IsOnlyStateProvinceFlag = true;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Addresses = new List<Address>();
            SalesTaxRates = new List<SalesTaxRate>();
        }
    }

    // Store
    public class Store
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key. Foreign key to Customer.BusinessEntityID.
        public string Name { get; set; } // Name. Name of the store.
        public int? SalesPersonId { get; set; } // SalesPersonID. ID of the sales person assigned to the customer. Foreign key to SalesPerson.BusinessEntityID.
        public string Demographics { get; set; } // Demographics. Demographic informationg about the store such as the number of employees, annual sales and store type.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Customer> Customers { get; set; } // Customer.FK_Customer_Store_StoreID

        // Foreign keys
        public virtual BusinessEntity BusinessEntity { get; set; } // FK_Store_BusinessEntity_BusinessEntityID
        public virtual SalesPerson SalesPerson { get; set; } // FK_Store_SalesPerson_SalesPersonID

        public Store()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Customers = new List<Customer>();
        }
    }

    // TransactionHistory
    public class TransactionHistory
    {
        public int TransactionId { get; set; } // TransactionID (Primary key). Primary key for TransactionHistory records.
        public int ProductId { get; set; } // ProductID. Product identification number. Foreign key to Product.ProductID.
        public int ReferenceOrderId { get; set; } // ReferenceOrderID. Purchase order, sales order, or work order identification number.
        public int ReferenceOrderLineId { get; set; } // ReferenceOrderLineID. Line number associated with the purchase order, sales order, or work order.
        public DateTime TransactionDate { get; set; } // TransactionDate. Date and time of the transaction.
        public string TransactionType { get; set; } // TransactionType. W = WorkOrder, S = SalesOrder, P = PurchaseOrder
        public int Quantity { get; set; } // Quantity. Product quantity.
        public decimal ActualCost { get; set; } // ActualCost. Product cost.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Product Product { get; set; } // FK_TransactionHistory_Product_ProductID

        public TransactionHistory()
        {
            ReferenceOrderLineId = 0;
            TransactionDate = System.DateTime.Now;
            ModifiedDate = System.DateTime.Now;
        }
    }

    // TransactionHistoryArchive
    public class TransactionHistoryArchive
    {
        public int TransactionId { get; set; } // TransactionID (Primary key). Primary key for TransactionHistoryArchive records.
        public int ProductId { get; set; } // ProductID. Product identification number. Foreign key to Product.ProductID.
        public int ReferenceOrderId { get; set; } // ReferenceOrderID. Purchase order, sales order, or work order identification number.
        public int ReferenceOrderLineId { get; set; } // ReferenceOrderLineID. Line number associated with the purchase order, sales order, or work order.
        public DateTime TransactionDate { get; set; } // TransactionDate. Date and time of the transaction.
        public string TransactionType { get; set; } // TransactionType. W = Work Order, S = Sales Order, P = Purchase Order
        public int Quantity { get; set; } // Quantity. Product quantity.
        public decimal ActualCost { get; set; } // ActualCost. Product cost.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        public TransactionHistoryArchive()
        {
            ReferenceOrderLineId = 0;
            TransactionDate = System.DateTime.Now;
            ModifiedDate = System.DateTime.Now;
        }
    }

    // UnitMeasure
    public class UnitMeasure
    {
        public string UnitMeasureCode { get; set; } // UnitMeasureCode (Primary key). Primary key.
        public string Name { get; set; } // Name. Unit of measure description.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<BillOfMaterial> BillOfMaterials { get; set; } // BillOfMaterials.FK_BillOfMaterials_UnitMeasure_UnitMeasureCode
        public virtual ICollection<Product> Products_SizeUnitMeasureCode { get; set; } // Product.FK_Product_UnitMeasure_SizeUnitMeasureCode
        public virtual ICollection<Product> Products_WeightUnitMeasureCode { get; set; } // Product.FK_Product_UnitMeasure_WeightUnitMeasureCode
        public virtual ICollection<ProductVendor> ProductVendors { get; set; } // ProductVendor.FK_ProductVendor_UnitMeasure_UnitMeasureCode

        public UnitMeasure()
        {
            ModifiedDate = System.DateTime.Now;
            BillOfMaterials = new List<BillOfMaterial>();
            Products_SizeUnitMeasureCode = new List<Product>();
            Products_WeightUnitMeasureCode = new List<Product>();
            ProductVendors = new List<ProductVendor>();
        }
    }

    // Vendor
    public class Vendor
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key for Vendor records.  Foreign key to BusinessEntity.BusinessEntityID
        public string AccountNumber { get; set; } // AccountNumber. Vendor account (identification) number.
        public string Name { get; set; } // Name. Company name.
        public byte CreditRating { get; set; } // CreditRating. 1 = Superior, 2 = Excellent, 3 = Above average, 4 = Average, 5 = Below average
        public bool PreferredVendorStatus { get; set; } // PreferredVendorStatus. 0 = Do not use if another vendor is available. 1 = Preferred over other vendors supplying the same product.
        public bool ActiveFlag { get; set; } // ActiveFlag. 0 = Vendor no longer used. 1 = Vendor is actively used.
        public string PurchasingWebServiceUrl { get; set; } // PurchasingWebServiceURL. Vendor URL.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<ProductVendor> ProductVendors { get; set; } // Many to many mapping
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; } // PurchaseOrderHeader.FK_PurchaseOrderHeader_Vendor_VendorID

        // Foreign keys
        public virtual BusinessEntity BusinessEntity { get; set; } // FK_Vendor_BusinessEntity_BusinessEntityID

        public Vendor()
        {
            PreferredVendorStatus = true;
            ActiveFlag = true;
            ModifiedDate = System.DateTime.Now;
            ProductVendors = new List<ProductVendor>();
            PurchaseOrderHeaders = new List<PurchaseOrderHeader>();
        }
    }

    // WorkOrder
    public class WorkOrder
    {
        public int WorkOrderId { get; set; } // WorkOrderID (Primary key). Primary key for WorkOrder records.
        public int ProductId { get; set; } // ProductID. Product identification number. Foreign key to Product.ProductID.
        public int OrderQty { get; set; } // OrderQty. Product quantity to build.
        public int StockedQty { get; internal set; } // StockedQty. Quantity built and put in inventory.
        public short ScrappedQty { get; set; } // ScrappedQty. Quantity that failed inspection.
        public DateTime StartDate { get; set; } // StartDate. Work order start date.
        public DateTime? EndDate { get; set; } // EndDate. Work order end date.
        public DateTime DueDate { get; set; } // DueDate. Work order due date.
        public short? ScrapReasonId { get; set; } // ScrapReasonID. Reason for inspection failure.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; } // Many to many mapping

        // Foreign keys
        public virtual Product Product { get; set; } // FK_WorkOrder_Product_ProductID
        public virtual ScrapReason ScrapReason { get; set; } // FK_WorkOrder_ScrapReason_ScrapReasonID

        public WorkOrder()
        {
            ModifiedDate = System.DateTime.Now;
            WorkOrderRoutings = new List<WorkOrderRouting>();
        }
    }

    // WorkOrderRouting
    public class WorkOrderRouting
    {
        public int WorkOrderId { get; set; } // WorkOrderID (Primary key). Primary key. Foreign key to WorkOrder.WorkOrderID.
        public int ProductId { get; set; } // ProductID (Primary key). Primary key. Foreign key to Product.ProductID.
        public short OperationSequence { get; set; } // OperationSequence (Primary key). Primary key. Indicates the manufacturing process sequence.
        public short LocationId { get; set; } // LocationID. Manufacturing location where the part is processed. Foreign key to Location.LocationID.
        public DateTime ScheduledStartDate { get; set; } // ScheduledStartDate. Planned manufacturing start date.
        public DateTime ScheduledEndDate { get; set; } // ScheduledEndDate. Planned manufacturing end date.
        public DateTime? ActualStartDate { get; set; } // ActualStartDate. Actual start date.
        public DateTime? ActualEndDate { get; set; } // ActualEndDate. Actual end date.
        public decimal? ActualResourceHrs { get; set; } // ActualResourceHrs. Number of manufacturing hours used.
        public decimal PlannedCost { get; set; } // PlannedCost. Estimated manufacturing cost.
        public decimal? ActualCost { get; set; } // ActualCost. Actual manufacturing cost.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Location Location { get; set; } // FK_WorkOrderRouting_Location_LocationID
        public virtual WorkOrder WorkOrder { get; set; } // FK_WorkOrderRouting_WorkOrder_WorkOrderID

        public WorkOrderRouting()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }


    // ************************************************************************
    // POCO Configuration

    // Address
    internal class AddressConfiguration : EntityTypeConfiguration<Address>
    {
        public AddressConfiguration(string schema = "Person")
        {
            ToTable(schema + ".Address");
            HasKey(x => x.AddressId);

            Property(x => x.AddressId).HasColumnName("AddressID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.AddressLine1).HasColumnName("AddressLine1").IsRequired().HasMaxLength(60);
            Property(x => x.AddressLine2).HasColumnName("AddressLine2").IsOptional().HasMaxLength(60);
            Property(x => x.City).HasColumnName("City").IsRequired().HasMaxLength(30);
            Property(x => x.StateProvinceId).HasColumnName("StateProvinceID").IsRequired();
            Property(x => x.PostalCode).HasColumnName("PostalCode").IsRequired().HasMaxLength(15);
            Property(x => x.SpatialLocation).HasColumnName("SpatialLocation").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.StateProvince).WithMany(b => b.Addresses).HasForeignKey(c => c.StateProvinceId); // FK_Address_StateProvince_StateProvinceID
        }
    }

    // AddressType
    internal class AddressTypeConfiguration : EntityTypeConfiguration<AddressType>
    {
        public AddressTypeConfiguration(string schema = "Person")
        {
            ToTable(schema + ".AddressType");
            HasKey(x => x.AddressTypeId);

            Property(x => x.AddressTypeId).HasColumnName("AddressTypeID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // BillOfMaterials
    internal class BillOfMaterialConfiguration : EntityTypeConfiguration<BillOfMaterial>
    {
        public BillOfMaterialConfiguration(string schema = "Production")
        {
            ToTable(schema + ".BillOfMaterials");
            HasKey(x => x.BillOfMaterialsId);

            Property(x => x.BillOfMaterialsId).HasColumnName("BillOfMaterialsID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductAssemblyId).HasColumnName("ProductAssemblyID").IsOptional();
            Property(x => x.ComponentId).HasColumnName("ComponentID").IsRequired();
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            Property(x => x.UnitMeasureCode).HasColumnName("UnitMeasureCode").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.BomLevel).HasColumnName("BOMLevel").IsRequired();
            Property(x => x.PerAssemblyQty).HasColumnName("PerAssemblyQty").IsRequired().HasPrecision(8,2);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasOptional(a => a.Product_ProductAssemblyId).WithMany(b => b.BillOfMaterials_ProductAssemblyId).HasForeignKey(c => c.ProductAssemblyId); // FK_BillOfMaterials_Product_ProductAssemblyID
            HasRequired(a => a.Product_ComponentId).WithMany(b => b.BillOfMaterials_ComponentId).HasForeignKey(c => c.ComponentId); // FK_BillOfMaterials_Product_ComponentID
            HasRequired(a => a.UnitMeasure).WithMany(b => b.BillOfMaterials).HasForeignKey(c => c.UnitMeasureCode); // FK_BillOfMaterials_UnitMeasure_UnitMeasureCode
        }
    }

    // BusinessEntity
    internal class BusinessEntityConfiguration : EntityTypeConfiguration<BusinessEntity>
    {
        public BusinessEntityConfiguration(string schema = "Person")
        {
            ToTable(schema + ".BusinessEntity");
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // BusinessEntityAddress
    internal class BusinessEntityAddressConfiguration : EntityTypeConfiguration<BusinessEntityAddress>
    {
        public BusinessEntityAddressConfiguration(string schema = "Person")
        {
            ToTable(schema + ".BusinessEntityAddress");
            HasKey(x => new { x.BusinessEntityId, x.AddressId, x.AddressTypeId });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AddressId).HasColumnName("AddressID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AddressTypeId).HasColumnName("AddressTypeID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.BusinessEntity).WithMany(b => b.BusinessEntityAddresses).HasForeignKey(c => c.BusinessEntityId); // FK_BusinessEntityAddress_BusinessEntity_BusinessEntityID
            HasRequired(a => a.Address).WithMany(b => b.BusinessEntityAddresses).HasForeignKey(c => c.AddressId); // FK_BusinessEntityAddress_Address_AddressID
            HasRequired(a => a.AddressType).WithMany(b => b.BusinessEntityAddresses).HasForeignKey(c => c.AddressTypeId); // FK_BusinessEntityAddress_AddressType_AddressTypeID
        }
    }

    // BusinessEntityContact
    internal class BusinessEntityContactConfiguration : EntityTypeConfiguration<BusinessEntityContact>
    {
        public BusinessEntityContactConfiguration(string schema = "Person")
        {
            ToTable(schema + ".BusinessEntityContact");
            HasKey(x => new { x.BusinessEntityId, x.PersonId, x.ContactTypeId });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PersonId).HasColumnName("PersonID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ContactTypeId).HasColumnName("ContactTypeID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.BusinessEntity).WithMany(b => b.BusinessEntityContacts).HasForeignKey(c => c.BusinessEntityId); // FK_BusinessEntityContact_BusinessEntity_BusinessEntityID
            HasRequired(a => a.Person).WithMany(b => b.BusinessEntityContacts).HasForeignKey(c => c.PersonId); // FK_BusinessEntityContact_Person_PersonID
            HasRequired(a => a.ContactType).WithMany(b => b.BusinessEntityContacts).HasForeignKey(c => c.ContactTypeId); // FK_BusinessEntityContact_ContactType_ContactTypeID
        }
    }

    // ContactType
    internal class ContactTypeConfiguration : EntityTypeConfiguration<ContactType>
    {
        public ContactTypeConfiguration(string schema = "Person")
        {
            ToTable(schema + ".ContactType");
            HasKey(x => x.ContactTypeId);

            Property(x => x.ContactTypeId).HasColumnName("ContactTypeID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // CountryRegion
    internal class CountryRegionConfiguration : EntityTypeConfiguration<CountryRegion>
    {
        public CountryRegionConfiguration(string schema = "Person")
        {
            ToTable(schema + ".CountryRegion");
            HasKey(x => x.CountryRegionCode);

            Property(x => x.CountryRegionCode).HasColumnName("CountryRegionCode").IsRequired().HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // CountryRegionCurrency
    internal class CountryRegionCurrencyConfiguration : EntityTypeConfiguration<CountryRegionCurrency>
    {
        public CountryRegionCurrencyConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".CountryRegionCurrency");
            HasKey(x => new { x.CountryRegionCode, x.CurrencyCode });

            Property(x => x.CountryRegionCode).HasColumnName("CountryRegionCode").IsRequired().HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CurrencyCode).HasColumnName("CurrencyCode").IsRequired().IsFixedLength().HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.CountryRegion).WithMany(b => b.CountryRegionCurrencies).HasForeignKey(c => c.CountryRegionCode); // FK_CountryRegionCurrency_CountryRegion_CountryRegionCode
            HasRequired(a => a.Currency).WithMany(b => b.CountryRegionCurrencies).HasForeignKey(c => c.CurrencyCode); // FK_CountryRegionCurrency_Currency_CurrencyCode
        }
    }

    // CreditCard
    internal class CreditCardConfiguration : EntityTypeConfiguration<CreditCard>
    {
        public CreditCardConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".CreditCard");
            HasKey(x => x.CreditCardId);

            Property(x => x.CreditCardId).HasColumnName("CreditCardID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CardType).HasColumnName("CardType").IsRequired().HasMaxLength(50);
            Property(x => x.CardNumber).HasColumnName("CardNumber").IsRequired().HasMaxLength(25);
            Property(x => x.ExpMonth).HasColumnName("ExpMonth").IsRequired();
            Property(x => x.ExpYear).HasColumnName("ExpYear").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // Culture
    internal class CultureConfiguration : EntityTypeConfiguration<Culture>
    {
        public CultureConfiguration(string schema = "Production")
        {
            ToTable(schema + ".Culture");
            HasKey(x => x.CultureId);

            Property(x => x.CultureId).HasColumnName("CultureID").IsRequired().IsFixedLength().HasMaxLength(6).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // Currency
    internal class CurrencyConfiguration : EntityTypeConfiguration<Currency>
    {
        public CurrencyConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".Currency");
            HasKey(x => x.CurrencyCode);

            Property(x => x.CurrencyCode).HasColumnName("CurrencyCode").IsRequired().IsFixedLength().HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // CurrencyRate
    internal class CurrencyRateConfiguration : EntityTypeConfiguration<CurrencyRate>
    {
        public CurrencyRateConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".CurrencyRate");
            HasKey(x => x.CurrencyRateId);

            Property(x => x.CurrencyRateId).HasColumnName("CurrencyRateID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CurrencyRateDate).HasColumnName("CurrencyRateDate").IsRequired();
            Property(x => x.FromCurrencyCode).HasColumnName("FromCurrencyCode").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.ToCurrencyCode).HasColumnName("ToCurrencyCode").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.AverageRate).HasColumnName("AverageRate").IsRequired().HasPrecision(19,4);
            Property(x => x.EndOfDayRate).HasColumnName("EndOfDayRate").IsRequired().HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Currency_FromCurrencyCode).WithMany(b => b.CurrencyRates_FromCurrencyCode).HasForeignKey(c => c.FromCurrencyCode); // FK_CurrencyRate_Currency_FromCurrencyCode
            HasRequired(a => a.Currency_ToCurrencyCode).WithMany(b => b.CurrencyRates_ToCurrencyCode).HasForeignKey(c => c.ToCurrencyCode); // FK_CurrencyRate_Currency_ToCurrencyCode
        }
    }

    // Customer
    internal class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".Customer");
            HasKey(x => x.CustomerId);

            Property(x => x.CustomerId).HasColumnName("CustomerID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.PersonId).HasColumnName("PersonID").IsOptional();
            Property(x => x.StoreId).HasColumnName("StoreID").IsOptional();
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsOptional();
            Property(x => x.AccountNumber).HasColumnName("AccountNumber").IsRequired().IsUnicode(false).HasMaxLength(10).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasOptional(a => a.Person).WithMany(b => b.Customers).HasForeignKey(c => c.PersonId); // FK_Customer_Person_PersonID
            HasOptional(a => a.Store).WithMany(b => b.Customers).HasForeignKey(c => c.StoreId); // FK_Customer_Store_StoreID
            HasOptional(a => a.SalesTerritory).WithMany(b => b.Customers).HasForeignKey(c => c.TerritoryId); // FK_Customer_SalesTerritory_TerritoryID
        }
    }

    // Department
    internal class DepartmentConfiguration : EntityTypeConfiguration<Department>
    {
        public DepartmentConfiguration(string schema = "HumanResources")
        {
            ToTable(schema + ".Department");
            HasKey(x => x.DepartmentId);

            Property(x => x.DepartmentId).HasColumnName("DepartmentID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.GroupName).HasColumnName("GroupName").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // Document
    internal class DocumentConfiguration : EntityTypeConfiguration<Document>
    {
        public DocumentConfiguration(string schema = "Production")
        {
            ToTable(schema + ".Document");
            HasKey(x => x.DocumentNode);

            Property(x => x.DocumentNode).HasColumnName("DocumentNode").IsRequired().HasMaxLength(892).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.DocumentLevel).HasColumnName("DocumentLevel").IsOptional().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.Title).HasColumnName("Title").IsRequired().HasMaxLength(50);
            Property(x => x.Owner).HasColumnName("Owner").IsRequired();
            Property(x => x.FolderFlag).HasColumnName("FolderFlag").IsRequired();
            Property(x => x.FileName).HasColumnName("FileName").IsRequired().HasMaxLength(400);
            Property(x => x.FileExtension).HasColumnName("FileExtension").IsRequired().HasMaxLength(8);
            Property(x => x.Revision).HasColumnName("Revision").IsRequired().IsFixedLength().HasMaxLength(5);
            Property(x => x.ChangeNumber).HasColumnName("ChangeNumber").IsRequired();
            Property(x => x.Status).HasColumnName("Status").IsRequired();
            Property(x => x.DocumentSummary).HasColumnName("DocumentSummary").IsOptional();
            Property(x => x.Document_).HasColumnName("Document").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Employee).WithMany(b => b.Documents).HasForeignKey(c => c.Owner); // FK_Document_Employee_Owner
        }
    }

    // EmailAddress
    internal class EmailAddressConfiguration : EntityTypeConfiguration<EmailAddress>
    {
        public EmailAddressConfiguration(string schema = "Person")
        {
            ToTable(schema + ".EmailAddress");
            HasKey(x => new { x.BusinessEntityId, x.EmailAddressId });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.EmailAddressId).HasColumnName("EmailAddressID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.EmailAddress_).HasColumnName("EmailAddress").IsOptional().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Person).WithMany(b => b.EmailAddresses).HasForeignKey(c => c.BusinessEntityId); // FK_EmailAddress_Person_BusinessEntityID
        }
    }

    // Employee
    internal class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration(string schema = "HumanResources")
        {
            ToTable(schema + ".Employee");
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.NationalIdNumber).HasColumnName("NationalIDNumber").IsRequired().HasMaxLength(15);
            Property(x => x.LoginId).HasColumnName("LoginID").IsRequired().HasMaxLength(256);
            Property(x => x.OrganizationNode).HasColumnName("OrganizationNode").IsOptional().HasMaxLength(892);
            Property(x => x.OrganizationLevel).HasColumnName("OrganizationLevel").IsOptional().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.JobTitle).HasColumnName("JobTitle").IsRequired().HasMaxLength(50);
            Property(x => x.BirthDate).HasColumnName("BirthDate").IsRequired();
            Property(x => x.MaritalStatus).HasColumnName("MaritalStatus").IsRequired().IsFixedLength().HasMaxLength(1);
            Property(x => x.Gender).HasColumnName("Gender").IsRequired().IsFixedLength().HasMaxLength(1);
            Property(x => x.HireDate).HasColumnName("HireDate").IsRequired();
            Property(x => x.SalariedFlag).HasColumnName("SalariedFlag").IsRequired();
            Property(x => x.VacationHours).HasColumnName("VacationHours").IsRequired();
            Property(x => x.SickLeaveHours).HasColumnName("SickLeaveHours").IsRequired();
            Property(x => x.CurrentFlag).HasColumnName("CurrentFlag").IsRequired();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Person).WithOptional(b => b.Employee); // FK_Employee_Person_BusinessEntityID
        }
    }

    // EmployeeDepartmentHistory
    internal class EmployeeDepartmentHistoryConfiguration : EntityTypeConfiguration<EmployeeDepartmentHistory>
    {
        public EmployeeDepartmentHistoryConfiguration(string schema = "HumanResources")
        {
            ToTable(schema + ".EmployeeDepartmentHistory");
            HasKey(x => new { x.BusinessEntityId, x.DepartmentId, x.ShiftId, x.StartDate });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.DepartmentId).HasColumnName("DepartmentID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ShiftId).HasColumnName("ShiftID").IsRequired();
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Employee).WithMany(b => b.EmployeeDepartmentHistories).HasForeignKey(c => c.BusinessEntityId); // FK_EmployeeDepartmentHistory_Employee_BusinessEntityID
            HasRequired(a => a.Department).WithMany(b => b.EmployeeDepartmentHistories).HasForeignKey(c => c.DepartmentId); // FK_EmployeeDepartmentHistory_Department_DepartmentID
            HasRequired(a => a.Shift).WithMany(b => b.EmployeeDepartmentHistories).HasForeignKey(c => c.ShiftId); // FK_EmployeeDepartmentHistory_Shift_ShiftID
        }
    }

    // EmployeePayHistory
    internal class EmployeePayHistoryConfiguration : EntityTypeConfiguration<EmployeePayHistory>
    {
        public EmployeePayHistoryConfiguration(string schema = "HumanResources")
        {
            ToTable(schema + ".EmployeePayHistory");
            HasKey(x => new { x.BusinessEntityId, x.RateChangeDate });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.RateChangeDate).HasColumnName("RateChangeDate").IsRequired();
            Property(x => x.Rate).HasColumnName("Rate").IsRequired().HasPrecision(19,4);
            Property(x => x.PayFrequency).HasColumnName("PayFrequency").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Employee).WithMany(b => b.EmployeePayHistories).HasForeignKey(c => c.BusinessEntityId); // FK_EmployeePayHistory_Employee_BusinessEntityID
        }
    }

    // Illustration
    internal class IllustrationConfiguration : EntityTypeConfiguration<Illustration>
    {
        public IllustrationConfiguration(string schema = "Production")
        {
            ToTable(schema + ".Illustration");
            HasKey(x => x.IllustrationId);

            Property(x => x.IllustrationId).HasColumnName("IllustrationID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Diagram).HasColumnName("Diagram").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // JobCandidate
    internal class JobCandidateConfiguration : EntityTypeConfiguration<JobCandidate>
    {
        public JobCandidateConfiguration(string schema = "HumanResources")
        {
            ToTable(schema + ".JobCandidate");
            HasKey(x => x.JobCandidateId);

            Property(x => x.JobCandidateId).HasColumnName("JobCandidateID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsOptional();
            Property(x => x.Resume).HasColumnName("Resume").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasOptional(a => a.Employee).WithMany(b => b.JobCandidates).HasForeignKey(c => c.BusinessEntityId); // FK_JobCandidate_Employee_BusinessEntityID
        }
    }

    // Location
    internal class LocationConfiguration : EntityTypeConfiguration<Location>
    {
        public LocationConfiguration(string schema = "Production")
        {
            ToTable(schema + ".Location");
            HasKey(x => x.LocationId);

            Property(x => x.LocationId).HasColumnName("LocationID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.CostRate).HasColumnName("CostRate").IsRequired().HasPrecision(10,4);
            Property(x => x.Availability).HasColumnName("Availability").IsRequired().HasPrecision(8,2);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // Password
    internal class PasswordConfiguration : EntityTypeConfiguration<Password>
    {
        public PasswordConfiguration(string schema = "Person")
        {
            ToTable(schema + ".Password");
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PasswordHash).HasColumnName("PasswordHash").IsRequired().IsUnicode(false).HasMaxLength(128);
            Property(x => x.PasswordSalt).HasColumnName("PasswordSalt").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Person).WithOptional(b => b.Password); // FK_Password_Person_BusinessEntityID
        }
    }

    // Person
    internal class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonConfiguration(string schema = "Person")
        {
            ToTable(schema + ".Person");
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PersonType).HasColumnName("PersonType").IsRequired().IsFixedLength().HasMaxLength(2);
            Property(x => x.NameStyle).HasColumnName("NameStyle").IsRequired();
            Property(x => x.Title).HasColumnName("Title").IsOptional().HasMaxLength(8);
            Property(x => x.FirstName).HasColumnName("FirstName").IsRequired().HasMaxLength(50);
            Property(x => x.MiddleName).HasColumnName("MiddleName").IsOptional().HasMaxLength(50);
            Property(x => x.LastName).HasColumnName("LastName").IsRequired().HasMaxLength(50);
            Property(x => x.Suffix).HasColumnName("Suffix").IsOptional().HasMaxLength(10);
            Property(x => x.EmailPromotion).HasColumnName("EmailPromotion").IsRequired();
            Property(x => x.AdditionalContactInfo).HasColumnName("AdditionalContactInfo").IsOptional();
            Property(x => x.Demographics).HasColumnName("Demographics").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.BusinessEntity).WithOptional(b => b.Person); // FK_Person_BusinessEntity_BusinessEntityID
        }
    }

    // PersonCreditCard
    internal class PersonCreditCardConfiguration : EntityTypeConfiguration<PersonCreditCard>
    {
        public PersonCreditCardConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".PersonCreditCard");
            HasKey(x => new { x.BusinessEntityId, x.CreditCardId });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CreditCardId).HasColumnName("CreditCardID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Person).WithMany(b => b.PersonCreditCards).HasForeignKey(c => c.BusinessEntityId); // FK_PersonCreditCard_Person_BusinessEntityID
            HasRequired(a => a.CreditCard).WithMany(b => b.PersonCreditCards).HasForeignKey(c => c.CreditCardId); // FK_PersonCreditCard_CreditCard_CreditCardID
        }
    }

    // PersonPhone
    internal class PersonPhoneConfiguration : EntityTypeConfiguration<PersonPhone>
    {
        public PersonPhoneConfiguration(string schema = "Person")
        {
            ToTable(schema + ".PersonPhone");
            HasKey(x => new { x.BusinessEntityId, x.PhoneNumber, x.PhoneNumberTypeId });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PhoneNumber).HasColumnName("PhoneNumber").IsRequired().HasMaxLength(25).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PhoneNumberTypeId).HasColumnName("PhoneNumberTypeID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Person).WithMany(b => b.PersonPhones).HasForeignKey(c => c.BusinessEntityId); // FK_PersonPhone_Person_BusinessEntityID
            HasRequired(a => a.PhoneNumberType).WithMany(b => b.PersonPhones).HasForeignKey(c => c.PhoneNumberTypeId); // FK_PersonPhone_PhoneNumberType_PhoneNumberTypeID
        }
    }

    // PhoneNumberType
    internal class PhoneNumberTypeConfiguration : EntityTypeConfiguration<PhoneNumberType>
    {
        public PhoneNumberTypeConfiguration(string schema = "Person")
        {
            ToTable(schema + ".PhoneNumberType");
            HasKey(x => x.PhoneNumberTypeId);

            Property(x => x.PhoneNumberTypeId).HasColumnName("PhoneNumberTypeID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // Product
    internal class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration(string schema = "Production")
        {
            ToTable(schema + ".Product");
            HasKey(x => x.ProductId);

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ProductNumber).HasColumnName("ProductNumber").IsRequired().HasMaxLength(25);
            Property(x => x.MakeFlag).HasColumnName("MakeFlag").IsRequired();
            Property(x => x.FinishedGoodsFlag).HasColumnName("FinishedGoodsFlag").IsRequired();
            Property(x => x.Color).HasColumnName("Color").IsOptional().HasMaxLength(15);
            Property(x => x.SafetyStockLevel).HasColumnName("SafetyStockLevel").IsRequired();
            Property(x => x.ReorderPoint).HasColumnName("ReorderPoint").IsRequired();
            Property(x => x.StandardCost).HasColumnName("StandardCost").IsRequired().HasPrecision(19,4);
            Property(x => x.ListPrice).HasColumnName("ListPrice").IsRequired().HasPrecision(19,4);
            Property(x => x.Size).HasColumnName("Size").IsOptional().HasMaxLength(5);
            Property(x => x.SizeUnitMeasureCode).HasColumnName("SizeUnitMeasureCode").IsOptional().IsFixedLength().HasMaxLength(3);
            Property(x => x.WeightUnitMeasureCode).HasColumnName("WeightUnitMeasureCode").IsOptional().IsFixedLength().HasMaxLength(3);
            Property(x => x.Weight).HasColumnName("Weight").IsOptional().HasPrecision(8,2);
            Property(x => x.DaysToManufacture).HasColumnName("DaysToManufacture").IsRequired();
            Property(x => x.ProductLine).HasColumnName("ProductLine").IsOptional().IsFixedLength().HasMaxLength(2);
            Property(x => x.Class).HasColumnName("Class").IsOptional().IsFixedLength().HasMaxLength(2);
            Property(x => x.Style).HasColumnName("Style").IsOptional().IsFixedLength().HasMaxLength(2);
            Property(x => x.ProductSubcategoryId).HasColumnName("ProductSubcategoryID").IsOptional();
            Property(x => x.ProductModelId).HasColumnName("ProductModelID").IsOptional();
            Property(x => x.SellStartDate).HasColumnName("SellStartDate").IsRequired();
            Property(x => x.SellEndDate).HasColumnName("SellEndDate").IsOptional();
            Property(x => x.DiscontinuedDate).HasColumnName("DiscontinuedDate").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasOptional(a => a.UnitMeasure_SizeUnitMeasureCode).WithMany(b => b.Products_SizeUnitMeasureCode).HasForeignKey(c => c.SizeUnitMeasureCode); // FK_Product_UnitMeasure_SizeUnitMeasureCode
            HasOptional(a => a.UnitMeasure_WeightUnitMeasureCode).WithMany(b => b.Products_WeightUnitMeasureCode).HasForeignKey(c => c.WeightUnitMeasureCode); // FK_Product_UnitMeasure_WeightUnitMeasureCode
            HasOptional(a => a.ProductSubcategory).WithMany(b => b.Products).HasForeignKey(c => c.ProductSubcategoryId); // FK_Product_ProductSubcategory_ProductSubcategoryID
            HasOptional(a => a.ProductModel).WithMany(b => b.Products).HasForeignKey(c => c.ProductModelId); // FK_Product_ProductModel_ProductModelID
        }
    }

    // ProductCategory
    internal class ProductCategoryConfiguration : EntityTypeConfiguration<ProductCategory>
    {
        public ProductCategoryConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductCategory");
            HasKey(x => x.ProductCategoryId);

            Property(x => x.ProductCategoryId).HasColumnName("ProductCategoryID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // ProductCostHistory
    internal class ProductCostHistoryConfiguration : EntityTypeConfiguration<ProductCostHistory>
    {
        public ProductCostHistoryConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductCostHistory");
            HasKey(x => new { x.ProductId, x.StartDate });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            Property(x => x.StandardCost).HasColumnName("StandardCost").IsRequired().HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Product).WithMany(b => b.ProductCostHistories).HasForeignKey(c => c.ProductId); // FK_ProductCostHistory_Product_ProductID
        }
    }

    // ProductDescription
    internal class ProductDescriptionConfiguration : EntityTypeConfiguration<ProductDescription>
    {
        public ProductDescriptionConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductDescription");
            HasKey(x => x.ProductDescriptionId);

            Property(x => x.ProductDescriptionId).HasColumnName("ProductDescriptionID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Description).HasColumnName("Description").IsRequired().HasMaxLength(400);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // ProductDocument
    internal class ProductDocumentConfiguration : EntityTypeConfiguration<ProductDocument>
    {
        public ProductDocumentConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductDocument");
            HasKey(x => new { x.ProductId, x.DocumentNode });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.DocumentNode).HasColumnName("DocumentNode").IsRequired().HasMaxLength(892).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Product).WithMany(b => b.ProductDocuments).HasForeignKey(c => c.ProductId); // FK_ProductDocument_Product_ProductID
            HasRequired(a => a.Document).WithMany(b => b.ProductDocuments).HasForeignKey(c => c.DocumentNode); // FK_ProductDocument_Document_DocumentNode
        }
    }

    // ProductInventory
    internal class ProductInventoryConfiguration : EntityTypeConfiguration<ProductInventory>
    {
        public ProductInventoryConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductInventory");
            HasKey(x => new { x.ProductId, x.LocationId });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.LocationId).HasColumnName("LocationID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Shelf).HasColumnName("Shelf").IsRequired().HasMaxLength(10);
            Property(x => x.Bin).HasColumnName("Bin").IsRequired();
            Property(x => x.Quantity).HasColumnName("Quantity").IsRequired();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Product).WithMany(b => b.ProductInventories).HasForeignKey(c => c.ProductId); // FK_ProductInventory_Product_ProductID
            HasRequired(a => a.Location).WithMany(b => b.ProductInventories).HasForeignKey(c => c.LocationId); // FK_ProductInventory_Location_LocationID
        }
    }

    // ProductListPriceHistory
    internal class ProductListPriceHistoryConfiguration : EntityTypeConfiguration<ProductListPriceHistory>
    {
        public ProductListPriceHistoryConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductListPriceHistory");
            HasKey(x => new { x.ProductId, x.StartDate });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            Property(x => x.ListPrice).HasColumnName("ListPrice").IsRequired().HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Product).WithMany(b => b.ProductListPriceHistories).HasForeignKey(c => c.ProductId); // FK_ProductListPriceHistory_Product_ProductID
        }
    }

    // ProductModel
    internal class ProductModelConfiguration : EntityTypeConfiguration<ProductModel>
    {
        public ProductModelConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductModel");
            HasKey(x => x.ProductModelId);

            Property(x => x.ProductModelId).HasColumnName("ProductModelID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.CatalogDescription).HasColumnName("CatalogDescription").IsOptional();
            Property(x => x.Instructions).HasColumnName("Instructions").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // ProductModelIllustration
    internal class ProductModelIllustrationConfiguration : EntityTypeConfiguration<ProductModelIllustration>
    {
        public ProductModelIllustrationConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductModelIllustration");
            HasKey(x => new { x.ProductModelId, x.IllustrationId });

            Property(x => x.ProductModelId).HasColumnName("ProductModelID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.IllustrationId).HasColumnName("IllustrationID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.ProductModel).WithMany(b => b.ProductModelIllustrations).HasForeignKey(c => c.ProductModelId); // FK_ProductModelIllustration_ProductModel_ProductModelID
            HasRequired(a => a.Illustration).WithMany(b => b.ProductModelIllustrations).HasForeignKey(c => c.IllustrationId); // FK_ProductModelIllustration_Illustration_IllustrationID
        }
    }

    // ProductModelProductDescriptionCulture
    internal class ProductModelProductDescriptionCultureConfiguration : EntityTypeConfiguration<ProductModelProductDescriptionCulture>
    {
        public ProductModelProductDescriptionCultureConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductModelProductDescriptionCulture");
            HasKey(x => new { x.ProductModelId, x.ProductDescriptionId, x.CultureId });

            Property(x => x.ProductModelId).HasColumnName("ProductModelID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductDescriptionId).HasColumnName("ProductDescriptionID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CultureId).HasColumnName("CultureID").IsRequired().IsFixedLength().HasMaxLength(6).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.ProductModel).WithMany(b => b.ProductModelProductDescriptionCultures).HasForeignKey(c => c.ProductModelId); // FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID
            HasRequired(a => a.ProductDescription).WithMany(b => b.ProductModelProductDescriptionCultures).HasForeignKey(c => c.ProductDescriptionId); // FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID
            HasRequired(a => a.Culture).WithMany(b => b.ProductModelProductDescriptionCultures).HasForeignKey(c => c.CultureId); // FK_ProductModelProductDescriptionCulture_Culture_CultureID
        }
    }

    // ProductPhoto
    internal class ProductPhotoConfiguration : EntityTypeConfiguration<ProductPhoto>
    {
        public ProductPhotoConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductPhoto");
            HasKey(x => x.ProductPhotoId);

            Property(x => x.ProductPhotoId).HasColumnName("ProductPhotoID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ThumbNailPhoto).HasColumnName("ThumbNailPhoto").IsOptional();
            Property(x => x.ThumbnailPhotoFileName).HasColumnName("ThumbnailPhotoFileName").IsOptional().HasMaxLength(50);
            Property(x => x.LargePhoto).HasColumnName("LargePhoto").IsOptional();
            Property(x => x.LargePhotoFileName).HasColumnName("LargePhotoFileName").IsOptional().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // ProductProductPhoto
    internal class ProductProductPhotoConfiguration : EntityTypeConfiguration<ProductProductPhoto>
    {
        public ProductProductPhotoConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductProductPhoto");
            HasKey(x => new { x.ProductId, x.ProductPhotoId });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductPhotoId).HasColumnName("ProductPhotoID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Primary).HasColumnName("Primary").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Product).WithMany(b => b.ProductProductPhotoes).HasForeignKey(c => c.ProductId); // FK_ProductProductPhoto_Product_ProductID
            HasRequired(a => a.ProductPhoto).WithMany(b => b.ProductProductPhotoes).HasForeignKey(c => c.ProductPhotoId); // FK_ProductProductPhoto_ProductPhoto_ProductPhotoID
        }
    }

    // ProductReview
    internal class ProductReviewConfiguration : EntityTypeConfiguration<ProductReview>
    {
        public ProductReviewConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductReview");
            HasKey(x => x.ProductReviewId);

            Property(x => x.ProductReviewId).HasColumnName("ProductReviewID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.ReviewerName).HasColumnName("ReviewerName").IsRequired().HasMaxLength(50);
            Property(x => x.ReviewDate).HasColumnName("ReviewDate").IsRequired();
            Property(x => x.EmailAddress).HasColumnName("EmailAddress").IsRequired().HasMaxLength(50);
            Property(x => x.Rating).HasColumnName("Rating").IsRequired();
            Property(x => x.Comments).HasColumnName("Comments").IsOptional().HasMaxLength(3850);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Product).WithMany(b => b.ProductReviews).HasForeignKey(c => c.ProductId); // FK_ProductReview_Product_ProductID
        }
    }

    // ProductSubcategory
    internal class ProductSubcategoryConfiguration : EntityTypeConfiguration<ProductSubcategory>
    {
        public ProductSubcategoryConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductSubcategory");
            HasKey(x => x.ProductSubcategoryId);

            Property(x => x.ProductSubcategoryId).HasColumnName("ProductSubcategoryID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductCategoryId).HasColumnName("ProductCategoryID").IsRequired();
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.ProductCategory).WithMany(b => b.ProductSubcategories).HasForeignKey(c => c.ProductCategoryId); // FK_ProductSubcategory_ProductCategory_ProductCategoryID
        }
    }

    // ProductVendor
    internal class ProductVendorConfiguration : EntityTypeConfiguration<ProductVendor>
    {
        public ProductVendorConfiguration(string schema = "Purchasing")
        {
            ToTable(schema + ".ProductVendor");
            HasKey(x => new { x.ProductId, x.BusinessEntityId });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AverageLeadTime).HasColumnName("AverageLeadTime").IsRequired();
            Property(x => x.StandardPrice).HasColumnName("StandardPrice").IsRequired().HasPrecision(19,4);
            Property(x => x.LastReceiptCost).HasColumnName("LastReceiptCost").IsOptional().HasPrecision(19,4);
            Property(x => x.LastReceiptDate).HasColumnName("LastReceiptDate").IsOptional();
            Property(x => x.MinOrderQty).HasColumnName("MinOrderQty").IsRequired();
            Property(x => x.MaxOrderQty).HasColumnName("MaxOrderQty").IsRequired();
            Property(x => x.OnOrderQty).HasColumnName("OnOrderQty").IsOptional();
            Property(x => x.UnitMeasureCode).HasColumnName("UnitMeasureCode").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Product).WithMany(b => b.ProductVendors).HasForeignKey(c => c.ProductId); // FK_ProductVendor_Product_ProductID
            HasRequired(a => a.Vendor).WithMany(b => b.ProductVendors).HasForeignKey(c => c.BusinessEntityId); // FK_ProductVendor_Vendor_BusinessEntityID
            HasRequired(a => a.UnitMeasure).WithMany(b => b.ProductVendors).HasForeignKey(c => c.UnitMeasureCode); // FK_ProductVendor_UnitMeasure_UnitMeasureCode
        }
    }

    // PurchaseOrderDetail
    internal class PurchaseOrderDetailConfiguration : EntityTypeConfiguration<PurchaseOrderDetail>
    {
        public PurchaseOrderDetailConfiguration(string schema = "Purchasing")
        {
            ToTable(schema + ".PurchaseOrderDetail");
            HasKey(x => new { x.PurchaseOrderId, x.PurchaseOrderDetailId });

            Property(x => x.PurchaseOrderId).HasColumnName("PurchaseOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PurchaseOrderDetailId).HasColumnName("PurchaseOrderDetailID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.DueDate).HasColumnName("DueDate").IsRequired();
            Property(x => x.OrderQty).HasColumnName("OrderQty").IsRequired();
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.UnitPrice).HasColumnName("UnitPrice").IsRequired().HasPrecision(19,4);
            Property(x => x.LineTotal).HasColumnName("LineTotal").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.ReceivedQty).HasColumnName("ReceivedQty").IsRequired().HasPrecision(8,2);
            Property(x => x.RejectedQty).HasColumnName("RejectedQty").IsRequired().HasPrecision(8,2);
            Property(x => x.StockedQty).HasColumnName("StockedQty").IsRequired().HasPrecision(9,2).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.PurchaseOrderHeader).WithMany(b => b.PurchaseOrderDetails).HasForeignKey(c => c.PurchaseOrderId); // FK_PurchaseOrderDetail_PurchaseOrderHeader_PurchaseOrderID
            HasRequired(a => a.Product).WithMany(b => b.PurchaseOrderDetails).HasForeignKey(c => c.ProductId); // FK_PurchaseOrderDetail_Product_ProductID
        }
    }

    // PurchaseOrderHeader
    internal class PurchaseOrderHeaderConfiguration : EntityTypeConfiguration<PurchaseOrderHeader>
    {
        public PurchaseOrderHeaderConfiguration(string schema = "Purchasing")
        {
            ToTable(schema + ".PurchaseOrderHeader");
            HasKey(x => x.PurchaseOrderId);

            Property(x => x.PurchaseOrderId).HasColumnName("PurchaseOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.RevisionNumber).HasColumnName("RevisionNumber").IsRequired();
            Property(x => x.Status).HasColumnName("Status").IsRequired();
            Property(x => x.EmployeeId).HasColumnName("EmployeeID").IsRequired();
            Property(x => x.VendorId).HasColumnName("VendorID").IsRequired();
            Property(x => x.ShipMethodId).HasColumnName("ShipMethodID").IsRequired();
            Property(x => x.OrderDate).HasColumnName("OrderDate").IsRequired();
            Property(x => x.ShipDate).HasColumnName("ShipDate").IsOptional();
            Property(x => x.SubTotal).HasColumnName("SubTotal").IsRequired().HasPrecision(19,4);
            Property(x => x.TaxAmt).HasColumnName("TaxAmt").IsRequired().HasPrecision(19,4);
            Property(x => x.Freight).HasColumnName("Freight").IsRequired().HasPrecision(19,4);
            Property(x => x.TotalDue).HasColumnName("TotalDue").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Employee).WithMany(b => b.PurchaseOrderHeaders).HasForeignKey(c => c.EmployeeId); // FK_PurchaseOrderHeader_Employee_EmployeeID
            HasRequired(a => a.Vendor).WithMany(b => b.PurchaseOrderHeaders).HasForeignKey(c => c.VendorId); // FK_PurchaseOrderHeader_Vendor_VendorID
            HasRequired(a => a.ShipMethod).WithMany(b => b.PurchaseOrderHeaders).HasForeignKey(c => c.ShipMethodId); // FK_PurchaseOrderHeader_ShipMethod_ShipMethodID
        }
    }

    // SalesOrderDetail
    internal class SalesOrderDetailConfiguration : EntityTypeConfiguration<SalesOrderDetail>
    {
        public SalesOrderDetailConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesOrderDetail");
            HasKey(x => new { x.SalesOrderId, x.SalesOrderDetailId });

            Property(x => x.SalesOrderId).HasColumnName("SalesOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.SalesOrderDetailId).HasColumnName("SalesOrderDetailID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CarrierTrackingNumber).HasColumnName("CarrierTrackingNumber").IsOptional().HasMaxLength(25);
            Property(x => x.OrderQty).HasColumnName("OrderQty").IsRequired();
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.SpecialOfferId).HasColumnName("SpecialOfferID").IsRequired();
            Property(x => x.UnitPrice).HasColumnName("UnitPrice").IsRequired().HasPrecision(19,4);
            Property(x => x.UnitPriceDiscount).HasColumnName("UnitPriceDiscount").IsRequired().HasPrecision(19,4);
            Property(x => x.LineTotal).HasColumnName("LineTotal").IsRequired().HasPrecision(38,6).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.SalesOrderHeader).WithMany(b => b.SalesOrderDetails).HasForeignKey(c => c.SalesOrderId); // FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID
            HasRequired(a => a.SpecialOfferProduct).WithMany(b => b.SalesOrderDetails).HasForeignKey(c => new { c.SpecialOfferId, c.ProductId }); // FK_SalesOrderDetail_SpecialOfferProduct_SpecialOfferIDProductID
        }
    }

    // SalesOrderHeader
    internal class SalesOrderHeaderConfiguration : EntityTypeConfiguration<SalesOrderHeader>
    {
        public SalesOrderHeaderConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesOrderHeader");
            HasKey(x => x.SalesOrderId);

            Property(x => x.SalesOrderId).HasColumnName("SalesOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.RevisionNumber).HasColumnName("RevisionNumber").IsRequired();
            Property(x => x.OrderDate).HasColumnName("OrderDate").IsRequired();
            Property(x => x.DueDate).HasColumnName("DueDate").IsRequired();
            Property(x => x.ShipDate).HasColumnName("ShipDate").IsOptional();
            Property(x => x.Status).HasColumnName("Status").IsRequired();
            Property(x => x.OnlineOrderFlag).HasColumnName("OnlineOrderFlag").IsRequired();
            Property(x => x.SalesOrderNumber).HasColumnName("SalesOrderNumber").IsRequired().HasMaxLength(25).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.PurchaseOrderNumber).HasColumnName("PurchaseOrderNumber").IsOptional().HasMaxLength(25);
            Property(x => x.AccountNumber).HasColumnName("AccountNumber").IsOptional().HasMaxLength(15);
            Property(x => x.CustomerId).HasColumnName("CustomerID").IsRequired();
            Property(x => x.SalesPersonId).HasColumnName("SalesPersonID").IsOptional();
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsOptional();
            Property(x => x.BillToAddressId).HasColumnName("BillToAddressID").IsRequired();
            Property(x => x.ShipToAddressId).HasColumnName("ShipToAddressID").IsRequired();
            Property(x => x.ShipMethodId).HasColumnName("ShipMethodID").IsRequired();
            Property(x => x.CreditCardId).HasColumnName("CreditCardID").IsOptional();
            Property(x => x.CreditCardApprovalCode).HasColumnName("CreditCardApprovalCode").IsOptional().IsUnicode(false).HasMaxLength(15);
            Property(x => x.CurrencyRateId).HasColumnName("CurrencyRateID").IsOptional();
            Property(x => x.SubTotal).HasColumnName("SubTotal").IsRequired().HasPrecision(19,4);
            Property(x => x.TaxAmt).HasColumnName("TaxAmt").IsRequired().HasPrecision(19,4);
            Property(x => x.Freight).HasColumnName("Freight").IsRequired().HasPrecision(19,4);
            Property(x => x.TotalDue).HasColumnName("TotalDue").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.Comment).HasColumnName("Comment").IsOptional().HasMaxLength(128);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Customer).WithMany(b => b.SalesOrderHeaders).HasForeignKey(c => c.CustomerId); // FK_SalesOrderHeader_Customer_CustomerID
            HasOptional(a => a.SalesPerson).WithMany(b => b.SalesOrderHeaders).HasForeignKey(c => c.SalesPersonId); // FK_SalesOrderHeader_SalesPerson_SalesPersonID
            HasOptional(a => a.SalesTerritory).WithMany(b => b.SalesOrderHeaders).HasForeignKey(c => c.TerritoryId); // FK_SalesOrderHeader_SalesTerritory_TerritoryID
            HasRequired(a => a.Address_BillToAddressId).WithMany(b => b.SalesOrderHeaders_BillToAddressId).HasForeignKey(c => c.BillToAddressId); // FK_SalesOrderHeader_Address_BillToAddressID
            HasRequired(a => a.Address_ShipToAddressId).WithMany(b => b.SalesOrderHeaders_ShipToAddressId).HasForeignKey(c => c.ShipToAddressId); // FK_SalesOrderHeader_Address_ShipToAddressID
            HasRequired(a => a.ShipMethod).WithMany(b => b.SalesOrderHeaders).HasForeignKey(c => c.ShipMethodId); // FK_SalesOrderHeader_ShipMethod_ShipMethodID
            HasOptional(a => a.CreditCard).WithMany(b => b.SalesOrderHeaders).HasForeignKey(c => c.CreditCardId); // FK_SalesOrderHeader_CreditCard_CreditCardID
            HasOptional(a => a.CurrencyRate).WithMany(b => b.SalesOrderHeaders).HasForeignKey(c => c.CurrencyRateId); // FK_SalesOrderHeader_CurrencyRate_CurrencyRateID
        }
    }

    // SalesOrderHeaderSalesReason
    internal class SalesOrderHeaderSalesReasonConfiguration : EntityTypeConfiguration<SalesOrderHeaderSalesReason>
    {
        public SalesOrderHeaderSalesReasonConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesOrderHeaderSalesReason");
            HasKey(x => new { x.SalesOrderId, x.SalesReasonId });

            Property(x => x.SalesOrderId).HasColumnName("SalesOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.SalesReasonId).HasColumnName("SalesReasonID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.SalesOrderHeader).WithMany(b => b.SalesOrderHeaderSalesReasons).HasForeignKey(c => c.SalesOrderId); // FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderID
            HasRequired(a => a.SalesReason).WithMany(b => b.SalesOrderHeaderSalesReasons).HasForeignKey(c => c.SalesReasonId); // FK_SalesOrderHeaderSalesReason_SalesReason_SalesReasonID
        }
    }

    // SalesPerson
    internal class SalesPersonConfiguration : EntityTypeConfiguration<SalesPerson>
    {
        public SalesPersonConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesPerson");
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsOptional();
            Property(x => x.SalesQuota).HasColumnName("SalesQuota").IsOptional().HasPrecision(19,4);
            Property(x => x.Bonus).HasColumnName("Bonus").IsRequired().HasPrecision(19,4);
            Property(x => x.CommissionPct).HasColumnName("CommissionPct").IsRequired().HasPrecision(10,4);
            Property(x => x.SalesYtd).HasColumnName("SalesYTD").IsRequired().HasPrecision(19,4);
            Property(x => x.SalesLastYear).HasColumnName("SalesLastYear").IsRequired().HasPrecision(19,4);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Employee).WithOptional(b => b.SalesPerson); // FK_SalesPerson_Employee_BusinessEntityID
            HasOptional(a => a.SalesTerritory).WithMany(b => b.SalesPersons).HasForeignKey(c => c.TerritoryId); // FK_SalesPerson_SalesTerritory_TerritoryID
        }
    }

    // SalesPersonQuotaHistory
    internal class SalesPersonQuotaHistoryConfiguration : EntityTypeConfiguration<SalesPersonQuotaHistory>
    {
        public SalesPersonQuotaHistoryConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesPersonQuotaHistory");
            HasKey(x => new { x.BusinessEntityId, x.QuotaDate });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.QuotaDate).HasColumnName("QuotaDate").IsRequired();
            Property(x => x.SalesQuota).HasColumnName("SalesQuota").IsRequired().HasPrecision(19,4);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.SalesPerson).WithMany(b => b.SalesPersonQuotaHistories).HasForeignKey(c => c.BusinessEntityId); // FK_SalesPersonQuotaHistory_SalesPerson_BusinessEntityID
        }
    }

    // SalesReason
    internal class SalesReasonConfiguration : EntityTypeConfiguration<SalesReason>
    {
        public SalesReasonConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesReason");
            HasKey(x => x.SalesReasonId);

            Property(x => x.SalesReasonId).HasColumnName("SalesReasonID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ReasonType).HasColumnName("ReasonType").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // SalesTaxRate
    internal class SalesTaxRateConfiguration : EntityTypeConfiguration<SalesTaxRate>
    {
        public SalesTaxRateConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesTaxRate");
            HasKey(x => x.SalesTaxRateId);

            Property(x => x.SalesTaxRateId).HasColumnName("SalesTaxRateID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.StateProvinceId).HasColumnName("StateProvinceID").IsRequired();
            Property(x => x.TaxType).HasColumnName("TaxType").IsRequired();
            Property(x => x.TaxRate).HasColumnName("TaxRate").IsRequired().HasPrecision(10,4);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.StateProvince).WithMany(b => b.SalesTaxRates).HasForeignKey(c => c.StateProvinceId); // FK_SalesTaxRate_StateProvince_StateProvinceID
        }
    }

    // SalesTerritory
    internal class SalesTerritoryConfiguration : EntityTypeConfiguration<SalesTerritory>
    {
        public SalesTerritoryConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesTerritory");
            HasKey(x => x.TerritoryId);

            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.CountryRegionCode).HasColumnName("CountryRegionCode").IsRequired().HasMaxLength(3);
            Property(x => x.Group).HasColumnName("Group").IsRequired().HasMaxLength(50);
            Property(x => x.SalesYtd).HasColumnName("SalesYTD").IsRequired().HasPrecision(19,4);
            Property(x => x.SalesLastYear).HasColumnName("SalesLastYear").IsRequired().HasPrecision(19,4);
            Property(x => x.CostYtd).HasColumnName("CostYTD").IsRequired().HasPrecision(19,4);
            Property(x => x.CostLastYear).HasColumnName("CostLastYear").IsRequired().HasPrecision(19,4);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.CountryRegion).WithMany(b => b.SalesTerritories).HasForeignKey(c => c.CountryRegionCode); // FK_SalesTerritory_CountryRegion_CountryRegionCode
        }
    }

    // SalesTerritoryHistory
    internal class SalesTerritoryHistoryConfiguration : EntityTypeConfiguration<SalesTerritoryHistory>
    {
        public SalesTerritoryHistoryConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesTerritoryHistory");
            HasKey(x => new { x.BusinessEntityId, x.TerritoryId, x.StartDate });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.SalesPerson).WithMany(b => b.SalesTerritoryHistories).HasForeignKey(c => c.BusinessEntityId); // FK_SalesTerritoryHistory_SalesPerson_BusinessEntityID
            HasRequired(a => a.SalesTerritory).WithMany(b => b.SalesTerritoryHistories).HasForeignKey(c => c.TerritoryId); // FK_SalesTerritoryHistory_SalesTerritory_TerritoryID
        }
    }

    // ScrapReason
    internal class ScrapReasonConfiguration : EntityTypeConfiguration<ScrapReason>
    {
        public ScrapReasonConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ScrapReason");
            HasKey(x => x.ScrapReasonId);

            Property(x => x.ScrapReasonId).HasColumnName("ScrapReasonID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // Shift
    internal class ShiftConfiguration : EntityTypeConfiguration<Shift>
    {
        public ShiftConfiguration(string schema = "HumanResources")
        {
            ToTable(schema + ".Shift");
            HasKey(x => x.ShiftId);

            Property(x => x.ShiftId).HasColumnName("ShiftID").IsRequired();
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.StartTime).HasColumnName("StartTime").IsRequired();
            Property(x => x.EndTime).HasColumnName("EndTime").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // ShipMethod
    internal class ShipMethodConfiguration : EntityTypeConfiguration<ShipMethod>
    {
        public ShipMethodConfiguration(string schema = "Purchasing")
        {
            ToTable(schema + ".ShipMethod");
            HasKey(x => x.ShipMethodId);

            Property(x => x.ShipMethodId).HasColumnName("ShipMethodID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ShipBase).HasColumnName("ShipBase").IsRequired().HasPrecision(19,4);
            Property(x => x.ShipRate).HasColumnName("ShipRate").IsRequired().HasPrecision(19,4);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // ShoppingCartItem
    internal class ShoppingCartItemConfiguration : EntityTypeConfiguration<ShoppingCartItem>
    {
        public ShoppingCartItemConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".ShoppingCartItem");
            HasKey(x => x.ShoppingCartItemId);

            Property(x => x.ShoppingCartItemId).HasColumnName("ShoppingCartItemID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ShoppingCartId).HasColumnName("ShoppingCartID").IsRequired().HasMaxLength(50);
            Property(x => x.Quantity).HasColumnName("Quantity").IsRequired();
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.DateCreated).HasColumnName("DateCreated").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Product).WithMany(b => b.ShoppingCartItems).HasForeignKey(c => c.ProductId); // FK_ShoppingCartItem_Product_ProductID
        }
    }

    // SpecialOffer
    internal class SpecialOfferConfiguration : EntityTypeConfiguration<SpecialOffer>
    {
        public SpecialOfferConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SpecialOffer");
            HasKey(x => x.SpecialOfferId);

            Property(x => x.SpecialOfferId).HasColumnName("SpecialOfferID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Description).HasColumnName("Description").IsRequired().HasMaxLength(255);
            Property(x => x.DiscountPct).HasColumnName("DiscountPct").IsRequired().HasPrecision(10,4);
            Property(x => x.Type).HasColumnName("Type").IsRequired().HasMaxLength(50);
            Property(x => x.Category).HasColumnName("Category").IsRequired().HasMaxLength(50);
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsRequired();
            Property(x => x.MinQty).HasColumnName("MinQty").IsRequired();
            Property(x => x.MaxQty).HasColumnName("MaxQty").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // SpecialOfferProduct
    internal class SpecialOfferProductConfiguration : EntityTypeConfiguration<SpecialOfferProduct>
    {
        public SpecialOfferProductConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SpecialOfferProduct");
            HasKey(x => new { x.SpecialOfferId, x.ProductId });

            Property(x => x.SpecialOfferId).HasColumnName("SpecialOfferID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.SpecialOffer).WithMany(b => b.SpecialOfferProducts).HasForeignKey(c => c.SpecialOfferId); // FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID
            HasRequired(a => a.Product).WithMany(b => b.SpecialOfferProducts).HasForeignKey(c => c.ProductId); // FK_SpecialOfferProduct_Product_ProductID
        }
    }

    // StateProvince
    internal class StateProvinceConfiguration : EntityTypeConfiguration<StateProvince>
    {
        public StateProvinceConfiguration(string schema = "Person")
        {
            ToTable(schema + ".StateProvince");
            HasKey(x => x.StateProvinceId);

            Property(x => x.StateProvinceId).HasColumnName("StateProvinceID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.StateProvinceCode).HasColumnName("StateProvinceCode").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.CountryRegionCode).HasColumnName("CountryRegionCode").IsRequired().HasMaxLength(3);
            Property(x => x.IsOnlyStateProvinceFlag).HasColumnName("IsOnlyStateProvinceFlag").IsRequired();
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsRequired();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.CountryRegion).WithMany(b => b.StateProvinces).HasForeignKey(c => c.CountryRegionCode); // FK_StateProvince_CountryRegion_CountryRegionCode
            HasRequired(a => a.SalesTerritory).WithMany(b => b.StateProvinces).HasForeignKey(c => c.TerritoryId); // FK_StateProvince_SalesTerritory_TerritoryID
        }
    }

    // Store
    internal class StoreConfiguration : EntityTypeConfiguration<Store>
    {
        public StoreConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".Store");
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.SalesPersonId).HasColumnName("SalesPersonID").IsOptional();
            Property(x => x.Demographics).HasColumnName("Demographics").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.BusinessEntity).WithOptional(b => b.Store); // FK_Store_BusinessEntity_BusinessEntityID
            HasOptional(a => a.SalesPerson).WithMany(b => b.Stores).HasForeignKey(c => c.SalesPersonId); // FK_Store_SalesPerson_SalesPersonID
        }
    }

    // TransactionHistory
    internal class TransactionHistoryConfiguration : EntityTypeConfiguration<TransactionHistory>
    {
        public TransactionHistoryConfiguration(string schema = "Production")
        {
            ToTable(schema + ".TransactionHistory");
            HasKey(x => x.TransactionId);

            Property(x => x.TransactionId).HasColumnName("TransactionID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.ReferenceOrderId).HasColumnName("ReferenceOrderID").IsRequired();
            Property(x => x.ReferenceOrderLineId).HasColumnName("ReferenceOrderLineID").IsRequired();
            Property(x => x.TransactionDate).HasColumnName("TransactionDate").IsRequired();
            Property(x => x.TransactionType).HasColumnName("TransactionType").IsRequired().IsFixedLength().HasMaxLength(1);
            Property(x => x.Quantity).HasColumnName("Quantity").IsRequired();
            Property(x => x.ActualCost).HasColumnName("ActualCost").IsRequired().HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Product).WithMany(b => b.TransactionHistories).HasForeignKey(c => c.ProductId); // FK_TransactionHistory_Product_ProductID
        }
    }

    // TransactionHistoryArchive
    internal class TransactionHistoryArchiveConfiguration : EntityTypeConfiguration<TransactionHistoryArchive>
    {
        public TransactionHistoryArchiveConfiguration(string schema = "Production")
        {
            ToTable(schema + ".TransactionHistoryArchive");
            HasKey(x => x.TransactionId);

            Property(x => x.TransactionId).HasColumnName("TransactionID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.ReferenceOrderId).HasColumnName("ReferenceOrderID").IsRequired();
            Property(x => x.ReferenceOrderLineId).HasColumnName("ReferenceOrderLineID").IsRequired();
            Property(x => x.TransactionDate).HasColumnName("TransactionDate").IsRequired();
            Property(x => x.TransactionType).HasColumnName("TransactionType").IsRequired().IsFixedLength().HasMaxLength(1);
            Property(x => x.Quantity).HasColumnName("Quantity").IsRequired();
            Property(x => x.ActualCost).HasColumnName("ActualCost").IsRequired().HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // UnitMeasure
    internal class UnitMeasureConfiguration : EntityTypeConfiguration<UnitMeasure>
    {
        public UnitMeasureConfiguration(string schema = "Production")
        {
            ToTable(schema + ".UnitMeasure");
            HasKey(x => x.UnitMeasureCode);

            Property(x => x.UnitMeasureCode).HasColumnName("UnitMeasureCode").IsRequired().IsFixedLength().HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // Vendor
    internal class VendorConfiguration : EntityTypeConfiguration<Vendor>
    {
        public VendorConfiguration(string schema = "Purchasing")
        {
            ToTable(schema + ".Vendor");
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AccountNumber).HasColumnName("AccountNumber").IsRequired().HasMaxLength(15);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.CreditRating).HasColumnName("CreditRating").IsRequired();
            Property(x => x.PreferredVendorStatus).HasColumnName("PreferredVendorStatus").IsRequired();
            Property(x => x.ActiveFlag).HasColumnName("ActiveFlag").IsRequired();
            Property(x => x.PurchasingWebServiceUrl).HasColumnName("PurchasingWebServiceURL").IsOptional().HasMaxLength(1024);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.BusinessEntity).WithOptional(b => b.Vendor); // FK_Vendor_BusinessEntity_BusinessEntityID
        }
    }

    // WorkOrder
    internal class WorkOrderConfiguration : EntityTypeConfiguration<WorkOrder>
    {
        public WorkOrderConfiguration(string schema = "Production")
        {
            ToTable(schema + ".WorkOrder");
            HasKey(x => x.WorkOrderId);

            Property(x => x.WorkOrderId).HasColumnName("WorkOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.OrderQty).HasColumnName("OrderQty").IsRequired();
            Property(x => x.StockedQty).HasColumnName("StockedQty").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.ScrappedQty).HasColumnName("ScrappedQty").IsRequired();
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            Property(x => x.DueDate).HasColumnName("DueDate").IsRequired();
            Property(x => x.ScrapReasonId).HasColumnName("ScrapReasonID").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Product).WithMany(b => b.WorkOrders).HasForeignKey(c => c.ProductId); // FK_WorkOrder_Product_ProductID
            HasOptional(a => a.ScrapReason).WithMany(b => b.WorkOrders).HasForeignKey(c => c.ScrapReasonId); // FK_WorkOrder_ScrapReason_ScrapReasonID
        }
    }

    // WorkOrderRouting
    internal class WorkOrderRoutingConfiguration : EntityTypeConfiguration<WorkOrderRouting>
    {
        public WorkOrderRoutingConfiguration(string schema = "Production")
        {
            ToTable(schema + ".WorkOrderRouting");
            HasKey(x => new { x.WorkOrderId, x.ProductId, x.OperationSequence });

            Property(x => x.WorkOrderId).HasColumnName("WorkOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.OperationSequence).HasColumnName("OperationSequence").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.LocationId).HasColumnName("LocationID").IsRequired();
            Property(x => x.ScheduledStartDate).HasColumnName("ScheduledStartDate").IsRequired();
            Property(x => x.ScheduledEndDate).HasColumnName("ScheduledEndDate").IsRequired();
            Property(x => x.ActualStartDate).HasColumnName("ActualStartDate").IsOptional();
            Property(x => x.ActualEndDate).HasColumnName("ActualEndDate").IsOptional();
            Property(x => x.ActualResourceHrs).HasColumnName("ActualResourceHrs").IsOptional().HasPrecision(9,4);
            Property(x => x.PlannedCost).HasColumnName("PlannedCost").IsRequired().HasPrecision(19,4);
            Property(x => x.ActualCost).HasColumnName("ActualCost").IsOptional().HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.WorkOrder).WithMany(b => b.WorkOrderRoutings).HasForeignKey(c => c.WorkOrderId); // FK_WorkOrderRouting_WorkOrder_WorkOrderID
            HasRequired(a => a.Location).WithMany(b => b.WorkOrderRoutings).HasForeignKey(c => c.LocationId); // FK_WorkOrderRouting_Location_LocationID
        }
    }

}
