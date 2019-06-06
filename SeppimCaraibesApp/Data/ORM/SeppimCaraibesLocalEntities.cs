namespace SeppimCaraibesApp.Data.ORM
{
    using System.Data.Entity;

    internal partial class SeppimCaraibesLocalEntities : DbContext
    {
        public SeppimCaraibesLocalEntities()
            : base("name=SeppimCaraibesLocalEntities")
        {
        }

        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Origin> Origins { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductsOrder> ProductsOrders { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<Shipment> Shipments { get; set; }
        public virtual DbSet<CustomersView> CustomersViews { get; set; }
        public virtual DbSet<InvoicesView> InvoicesViews { get; set; }
        public virtual DbSet<OrdersView> OrdersViews { get; set; }
        public virtual DbSet<PreOrdersView> PreOrdersViews { get; set; }
        public virtual DbSet<ProductsView> ProductsViews { get; set; }
        public virtual DbSet<ProvidersView> ProvidersViews { get; set; }
        public virtual DbSet<QuotesView> QuotesViews { get; set; }
        public virtual DbSet<ShipmentsView> ShipmentsViews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .Property(e => e.ContractDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.DocRequired)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Observations)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Incoterm)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.EXW)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.Freight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.FCA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.FOB)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.Insurance)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.Inspection)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Order>()
                .HasOptional(e => e.Shipment)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Origin>()
                .Property(e => e.Acronyms)
                .IsFixedLength();

            modelBuilder.Entity<Origin>()
                .HasMany(e => e.Products)
                .WithMany(e => e.Origins)
                .Map(m => m.ToTable("ProductsOrigins").MapLeftKey("OriginId").MapRightKey("ProductId"));

            modelBuilder.Entity<Product>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.QtyPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.SalePrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Providers)
                .WithMany(e => e.Products)
                .Map(m => m.ToTable("ProductsProviders").MapLeftKey("ProductId").MapRightKey("ProviderId"));

            modelBuilder.Entity<ProductsOrder>()
                .Property(e => e.Discount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ProductsOrder>()
                .Property(e => e.Interests)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Shipment>()
                .Property(e => e.GrossWeight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Shipment>()
                .Property(e => e.NetWeight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<InvoicesView>()
                .Property(e => e.Contract_Description)
                .IsUnicode(false);

            modelBuilder.Entity<InvoicesView>()
                .Property(e => e.Product_Interests)
                .HasPrecision(18, 4);

            modelBuilder.Entity<InvoicesView>()
                .Property(e => e.Product_Discount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<InvoicesView>()
                .Property(e => e.Freight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<InvoicesView>()
                .Property(e => e.FCA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<InvoicesView>()
                .Property(e => e.FOB)
                .HasPrecision(18, 4);

            modelBuilder.Entity<InvoicesView>()
                .Property(e => e.Insurance)
                .HasPrecision(18, 4);

            modelBuilder.Entity<InvoicesView>()
                .Property(e => e.Inspection)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OrdersView>()
                .Property(e => e.Unit_Price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OrdersView>()
                .Property(e => e.Product_Discount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OrdersView>()
                .Property(e => e.Incoterm)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OrdersView>()
                .Property(e => e.Contract_Description)
                .IsUnicode(false);

            modelBuilder.Entity<OrdersView>()
                .Property(e => e.Documents_Required)
                .IsUnicode(false);

            modelBuilder.Entity<ProductsView>()
                .Property(e => e.Unit_Price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ProductsView>()
                .Property(e => e.Qty_Price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ProductsView>()
                .Property(e => e.Sale_Price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ProductsView>()
                .Property(e => e.Acronyms)
                .IsFixedLength();

            modelBuilder.Entity<QuotesView>()
                .Property(e => e.Incoterm)
                .HasPrecision(18, 4);

            modelBuilder.Entity<QuotesView>()
                .Property(e => e.Unit_Price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<QuotesView>()
                .Property(e => e.Discount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<QuotesView>()
                .Property(e => e.EXW)
                .HasPrecision(18, 4);

            modelBuilder.Entity<QuotesView>()
                .Property(e => e.Freight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<QuotesView>()
                .Property(e => e.Gross_Weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<QuotesView>()
                .Property(e => e.Net_Weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ShipmentsView>()
                .Property(e => e.Gross_Weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ShipmentsView>()
                .Property(e => e.Net_Weight)
                .HasPrecision(18, 4);
        }
    }
}
