using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagement.Entities
{
    /// <summary> 
    /// Represents a stocktransfer entity with essential details
    /// </summary>
    public class StockTransfer
    {
        /// <summary>
        /// TenantId of the StockTransfer 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the StockTransfer 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the StockTransfer 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the StockTransfer 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Foreign key referencing the ProductVariant to which the StockTransfer belongs 
        /// </summary>
        public Guid? ProductVariantId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ProductVariant
        /// </summary>
        [ForeignKey("ProductVariantId")]
        public ProductVariant? ProductVariantId_ProductVariant { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the StockTransfer belongs 
        /// </summary>
        public Guid? SourceLocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("SourceLocationId")]
        public Location? SourceLocationId_Location { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the StockTransfer belongs 
        /// </summary>
        public Guid? DestinationLocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("DestinationLocationId")]
        public Location? DestinationLocationId_Location { get; set; }
        /// <summary>
        /// Quantity of the StockTransfer 
        /// </summary>
        public int? Quantity { get; set; }

        /// <summary>
        /// CreatedOn of the StockTransfer 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the StockTransfer 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the StockTransfer 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the StockTransfer 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}