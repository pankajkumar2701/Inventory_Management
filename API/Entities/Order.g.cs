using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagement.Entities
{
    /// <summary> 
    /// Represents a order entity with essential details
    /// </summary>
    public class Order
    {
        /// <summary>
        /// TenantId of the Order 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Order 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the Order 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the Order 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Customer to which the Order belongs 
        /// </summary>
        public Guid? CustomerId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Customer
        /// </summary>
        [ForeignKey("CustomerId")]
        public Customer? CustomerId_Customer { get; set; }
        /// <summary>
        /// Foreign key referencing the OrderStatus to which the Order belongs 
        /// </summary>
        public Guid? OrderStatusId { get; set; }

        /// <summary>
        /// Navigation property representing the associated OrderStatus
        /// </summary>
        [ForeignKey("OrderStatusId")]
        public OrderStatus? OrderStatusId_OrderStatus { get; set; }
        /// <summary>
        /// Foreign key referencing the PaymentMethod to which the Order belongs 
        /// </summary>
        public Guid? PaymentMethodId { get; set; }

        /// <summary>
        /// Navigation property representing the associated PaymentMethod
        /// </summary>
        [ForeignKey("PaymentMethodId")]
        public PaymentMethod? PaymentMethodId_PaymentMethod { get; set; }
        /// <summary>
        /// Foreign key referencing the ShippingMethod to which the Order belongs 
        /// </summary>
        public Guid? ShippingMethodId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ShippingMethod
        /// </summary>
        [ForeignKey("ShippingMethodId")]
        public ShippingMethod? ShippingMethodId_ShippingMethod { get; set; }

        /// <summary>
        /// CreatedOn of the Order 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Order 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Order 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Order 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}