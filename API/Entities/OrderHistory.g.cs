using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagement.Entities
{
    /// <summary> 
    /// Represents a orderhistory entity with essential details
    /// </summary>
    public class OrderHistory
    {
        /// <summary>
        /// TenantId of the OrderHistory 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the OrderHistory 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the OrderHistory 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the OrderHistory 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Order to which the OrderHistory belongs 
        /// </summary>
        public Guid? OrderId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Order
        /// </summary>
        [ForeignKey("OrderId")]
        public Order? OrderId_Order { get; set; }
        /// <summary>
        /// Status of the OrderHistory 
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// CreatedOn of the OrderHistory 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the OrderHistory 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the OrderHistory 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the OrderHistory 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}