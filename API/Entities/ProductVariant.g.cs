using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagement.Entities
{
    /// <summary> 
    /// Represents a productvariant entity with essential details
    /// </summary>
    public class ProductVariant
    {
        /// <summary>
        /// TenantId of the ProductVariant 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ProductVariant 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the ProductVariant 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the ProductVariant 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Product to which the ProductVariant belongs 
        /// </summary>
        public Guid? ProductId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("ProductId")]
        public Product? ProductId_Product { get; set; }

        /// <summary>
        /// CreatedOn of the ProductVariant 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ProductVariant 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ProductVariant 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ProductVariant 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}