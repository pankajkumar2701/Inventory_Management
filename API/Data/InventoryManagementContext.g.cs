using Microsoft.EntityFrameworkCore;
using InventoryManagement.Entities;

namespace InventoryManagement.Data
{
    public class InventoryManagementContext : DbContext
    {
        protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-GFUVFUP;Initial Catalog=T754323_Inventory_Management;Persist Security Info=True;user id=pankazz;password=123456;Integrated Security=false;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInRole>().HasKey(a => a.Id);
            modelBuilder.Entity<UserToken>().HasKey(a => a.Id);
            modelBuilder.Entity<RoleEntitlement>().HasKey(a => a.Id);
            modelBuilder.Entity<Entity>().HasKey(a => a.Id);
            modelBuilder.Entity<Tenant>().HasKey(a => a.Id);
            modelBuilder.Entity<User>().HasKey(a => a.Id);
            modelBuilder.Entity<Role>().HasKey(a => a.Id);
            modelBuilder.Entity<Product>().HasKey(a => a.Id);
            modelBuilder.Entity<StockAdjustment>().HasKey(a => a.Id);
            modelBuilder.Entity<StockTransfer>().HasKey(a => a.Id);
            modelBuilder.Entity<StockMovement>().HasKey(a => a.Id);
            modelBuilder.Entity<Order>().HasKey(a => a.Id);
            modelBuilder.Entity<OrderItem>().HasKey(a => a.Id);
            modelBuilder.Entity<OrderStatus>().HasKey(a => a.Id);
            modelBuilder.Entity<OrderNote>().HasKey(a => a.Id);
            modelBuilder.Entity<Return>().HasKey(a => a.Id);
            modelBuilder.Entity<ReturnReason>().HasKey(a => a.Id);
            modelBuilder.Entity<OrderHistory>().HasKey(a => a.Id);
            modelBuilder.Entity<Customer>().HasKey(a => a.Id);
            modelBuilder.Entity<ProductCategory>().HasKey(a => a.Id);
            modelBuilder.Entity<ProductVariant>().HasKey(a => a.Id);
            modelBuilder.Entity<Warehouse>().HasKey(a => a.Id);
            modelBuilder.Entity<Location>().HasKey(a => a.Id);
            modelBuilder.Entity<LotNumber>().HasKey(a => a.Id);
            modelBuilder.Entity<ExpirationDate>().HasKey(a => a.Id);
            modelBuilder.Entity<SerialNumber>().HasKey(a => a.Id);
            modelBuilder.Entity<Supplier>().HasKey(a => a.Id);
            modelBuilder.Entity<UnitOfMeasurement>().HasKey(a => a.Id);
            modelBuilder.Entity<InventoryReport>().HasKey(a => a.Id);
            modelBuilder.Entity<ReorderLevel>().HasKey(a => a.Id);
            modelBuilder.Entity<DemandForecasting>().HasKey(a => a.Id);
            modelBuilder.Entity<Barcode>().HasKey(a => a.Id);
            modelBuilder.Entity<ProductService>().HasKey(a => a.Id);
            modelBuilder.Entity<PaymentMethod>().HasKey(a => a.Id);
            modelBuilder.Entity<ShippingMethod>().HasKey(a => a.Id);
            modelBuilder.Entity<ShippingAddress>().HasKey(a => a.Id);
            modelBuilder.Entity<BillingAddress>().HasKey(a => a.Id);
            modelBuilder.Entity<Tax>().HasKey(a => a.Id);
            modelBuilder.Entity<Discount>().HasKey(a => a.Id);
            modelBuilder.Entity<Currency>().HasKey(a => a.Id);
            modelBuilder.Entity<PaymentStatus>().HasKey(a => a.Id);
            modelBuilder.Entity<DeliveryStatus>().HasKey(a => a.Id);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.RoleId_Role).WithMany().HasForeignKey(c => c.RoleId);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.UserId_User).WithMany().HasForeignKey(c => c.UserId);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.CreatedBy_User).WithMany().HasForeignKey(c => c.CreatedBy);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.UpdatedBy_User).WithMany().HasForeignKey(c => c.UpdatedBy);
            modelBuilder.Entity<UserToken>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<UserToken>().HasOne(a => a.UserId_User).WithMany().HasForeignKey(c => c.UserId);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.RoleId_Role).WithMany().HasForeignKey(c => c.RoleId);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.EntityId_Entity).WithMany().HasForeignKey(c => c.EntityId);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.CreatedBy_User).WithMany().HasForeignKey(c => c.CreatedBy);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.UpdatedBy_User).WithMany().HasForeignKey(c => c.UpdatedBy);
            modelBuilder.Entity<Entity>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<Entity>().HasOne(a => a.CreatedBy_User).WithMany().HasForeignKey(c => c.CreatedBy);
            modelBuilder.Entity<Entity>().HasOne(a => a.UpdatedBy_User).WithMany().HasForeignKey(c => c.UpdatedBy);
            modelBuilder.Entity<User>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<Role>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<Role>().HasOne(a => a.CreatedBy_User).WithMany().HasForeignKey(c => c.CreatedBy);
            modelBuilder.Entity<Role>().HasOne(a => a.UpdatedBy_User).WithMany().HasForeignKey(c => c.UpdatedBy);
            modelBuilder.Entity<Product>().HasOne(a => a.ProductCategoryId_ProductCategory).WithMany().HasForeignKey(c => c.ProductCategoryId);
            modelBuilder.Entity<StockAdjustment>().HasOne(a => a.ProductVariantId_ProductVariant).WithMany().HasForeignKey(c => c.ProductVariantId);
            modelBuilder.Entity<StockAdjustment>().HasOne(a => a.LocationId_Location).WithMany().HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<StockTransfer>().HasOne(a => a.ProductVariantId_ProductVariant).WithMany().HasForeignKey(c => c.ProductVariantId);
            modelBuilder.Entity<StockTransfer>().HasOne(a => a.SourceLocationId_Location).WithMany().HasForeignKey(c => c.SourceLocationId);
            modelBuilder.Entity<StockTransfer>().HasOne(a => a.DestinationLocationId_Location).WithMany().HasForeignKey(c => c.DestinationLocationId);
            modelBuilder.Entity<StockMovement>().HasOne(a => a.LotNumberId_LotNumber).WithMany().HasForeignKey(c => c.LotNumberId);
            modelBuilder.Entity<StockMovement>().HasOne(a => a.ExpirationDateId_ExpirationDate).WithMany().HasForeignKey(c => c.ExpirationDateId);
            modelBuilder.Entity<StockMovement>().HasOne(a => a.SerialNumberId_SerialNumber).WithMany().HasForeignKey(c => c.SerialNumberId);
            modelBuilder.Entity<StockMovement>().HasOne(a => a.SupplierId_Supplier).WithMany().HasForeignKey(c => c.SupplierId);
            modelBuilder.Entity<StockMovement>().HasOne(a => a.UnitOfMeasurementId_UnitOfMeasurement).WithMany().HasForeignKey(c => c.UnitOfMeasurementId);
            modelBuilder.Entity<StockMovement>().HasOne(a => a.InventoryReportId_InventoryReport).WithMany().HasForeignKey(c => c.InventoryReportId);
            modelBuilder.Entity<Order>().HasOne(a => a.CustomerId_Customer).WithMany().HasForeignKey(c => c.CustomerId);
            modelBuilder.Entity<Order>().HasOne(a => a.OrderStatusId_OrderStatus).WithMany().HasForeignKey(c => c.OrderStatusId);
            modelBuilder.Entity<Order>().HasOne(a => a.PaymentMethodId_PaymentMethod).WithMany().HasForeignKey(c => c.PaymentMethodId);
            modelBuilder.Entity<Order>().HasOne(a => a.ShippingMethodId_ShippingMethod).WithMany().HasForeignKey(c => c.ShippingMethodId);
            modelBuilder.Entity<OrderItem>().HasOne(a => a.OrderId_Order).WithMany().HasForeignKey(c => c.OrderId);
            modelBuilder.Entity<OrderItem>().HasOne(a => a.ProductServiceId_ProductService).WithMany().HasForeignKey(c => c.ProductServiceId);
            modelBuilder.Entity<OrderHistory>().HasOne(a => a.OrderId_Order).WithMany().HasForeignKey(c => c.OrderId);
            modelBuilder.Entity<ProductVariant>().HasOne(a => a.ProductId_Product).WithMany().HasForeignKey(c => c.ProductId);
            modelBuilder.Entity<Location>().HasOne(a => a.WarehouseId_Warehouse).WithMany().HasForeignKey(c => c.WarehouseId);
        }

        public DbSet<UserInRole> UserInRole { get; set; }
        public DbSet<UserToken> UserToken { get; set; }
        public DbSet<RoleEntitlement> RoleEntitlement { get; set; }
        public DbSet<Entity> Entity { get; set; }
        public DbSet<Tenant> Tenant { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<StockAdjustment> StockAdjustment { get; set; }
        public DbSet<StockTransfer> StockTransfer { get; set; }
        public DbSet<StockMovement> StockMovement { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<OrderNote> OrderNote { get; set; }
        public DbSet<Return> Return { get; set; }
        public DbSet<ReturnReason> ReturnReason { get; set; }
        public DbSet<OrderHistory> OrderHistory { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductVariant> ProductVariant { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<LotNumber> LotNumber { get; set; }
        public DbSet<ExpirationDate> ExpirationDate { get; set; }
        public DbSet<SerialNumber> SerialNumber { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<UnitOfMeasurement> UnitOfMeasurement { get; set; }
        public DbSet<InventoryReport> InventoryReport { get; set; }
        public DbSet<ReorderLevel> ReorderLevel { get; set; }
        public DbSet<DemandForecasting> DemandForecasting { get; set; }
        public DbSet<Barcode> Barcode { get; set; }
        public DbSet<ProductService> ProductService { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }
        public DbSet<ShippingMethod> ShippingMethod { get; set; }
        public DbSet<ShippingAddress> ShippingAddress { get; set; }
        public DbSet<BillingAddress> BillingAddress { get; set; }
        public DbSet<Tax> Tax { get; set; }
        public DbSet<Discount> Discount { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<PaymentStatus> PaymentStatus { get; set; }
        public DbSet<DeliveryStatus> DeliveryStatus { get; set; }
    }
}