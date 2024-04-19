using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagement.Entities
{
    /// <summary> 
    /// Represents a orderstatus entity with essential details
    /// </summary>
    public class OrderStatus
    {
        /// <summary>
        /// TenantId of the OrderStatus 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the OrderStatus 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the OrderStatus 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the OrderStatus 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// CreatedOn of the OrderStatus 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the OrderStatus 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the OrderStatus 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the OrderStatus 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}