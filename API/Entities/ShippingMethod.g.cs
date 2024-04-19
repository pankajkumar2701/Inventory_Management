using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagement.Entities
{
    /// <summary> 
    /// Represents a shippingmethod entity with essential details
    /// </summary>
    public class ShippingMethod
    {
        /// <summary>
        /// TenantId of the ShippingMethod 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ShippingMethod 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the ShippingMethod 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the ShippingMethod 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// CreatedOn of the ShippingMethod 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ShippingMethod 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ShippingMethod 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ShippingMethod 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}