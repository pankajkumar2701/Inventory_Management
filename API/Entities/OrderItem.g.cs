using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagement.Entities
{
    /// <summary> 
    /// Represents a orderitem entity with essential details
    /// </summary>
    public class OrderItem
    {
        /// <summary>
        /// TenantId of the OrderItem 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the OrderItem 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the OrderItem 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the OrderItem 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Order to which the OrderItem belongs 
        /// </summary>
        public Guid? OrderId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Order
        /// </summary>
        [ForeignKey("OrderId")]
        public Order? OrderId_Order { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductService to which the OrderItem belongs 
        /// </summary>
        public Guid? ProductServiceId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductService
        /// </summary>
        [ForeignKey("ProductServiceId")]
        public ProductService? ProductServiceId_ProductService { get; set; }
        /// <summary>
        /// Quantity of the OrderItem 
        /// </summary>
        public int? Quantity { get; set; }
        /// <summary>
        /// Price of the OrderItem 
        /// </summary>
        public int? Price { get; set; }

        /// <summary>
        /// CreatedOn of the OrderItem 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the OrderItem 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the OrderItem 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the OrderItem 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}