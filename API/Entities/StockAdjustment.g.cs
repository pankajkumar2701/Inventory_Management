using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagement.Entities
{
    /// <summary> 
    /// Represents a stockadjustment entity with essential details
    /// </summary>
    public class StockAdjustment
    {
        /// <summary>
        /// TenantId of the StockAdjustment 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the StockAdjustment 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the StockAdjustment 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the StockAdjustment 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductVariant to which the StockAdjustment belongs 
        /// </summary>
        public Guid? ProductVariantId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductVariant
        /// </summary>
        [ForeignKey("ProductVariantId")]
        public ProductVariant? ProductVariantId_ProductVariant { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the StockAdjustment belongs 
        /// </summary>
        public Guid? LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }
        /// <summary>
        /// Quantity of the StockAdjustment 
        /// </summary>
        public int? Quantity { get; set; }

        /// <summary>
        /// CreatedOn of the StockAdjustment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the StockAdjustment 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the StockAdjustment 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the StockAdjustment 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}