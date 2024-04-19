using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagement.Entities
{
    /// <summary> 
    /// Represents a stockmovement entity with essential details
    /// </summary>
    public class StockMovement
    {
        /// <summary>
        /// TenantId of the StockMovement 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the StockMovement 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the StockMovement 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the StockMovement 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Foreign key referencing the LotNumber to which the StockMovement belongs 
        /// </summary>
        public Guid? LotNumberId { get; set; }

        /// <summary>
        /// Navigation property representing the associated LotNumber
        /// </summary>
        [ForeignKey("LotNumberId")]
        public LotNumber? LotNumberId_LotNumber { get; set; }
        /// <summary>
        /// Foreign key referencing the ExpirationDate to which the StockMovement belongs 
        /// </summary>
        public Guid? ExpirationDateId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ExpirationDate
        /// </summary>
        [ForeignKey("ExpirationDateId")]
        public ExpirationDate? ExpirationDateId_ExpirationDate { get; set; }
        /// <summary>
        /// Foreign key referencing the SerialNumber to which the StockMovement belongs 
        /// </summary>
        public Guid? SerialNumberId { get; set; }

        /// <summary>
        /// Navigation property representing the associated SerialNumber
        /// </summary>
        [ForeignKey("SerialNumberId")]
        public SerialNumber? SerialNumberId_SerialNumber { get; set; }
        /// <summary>
        /// Foreign key referencing the Supplier to which the StockMovement belongs 
        /// </summary>
        public Guid? SupplierId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Supplier
        /// </summary>
        [ForeignKey("SupplierId")]
        public Supplier? SupplierId_Supplier { get; set; }
        /// <summary>
        /// Foreign key referencing the UnitOfMeasurement to which the StockMovement belongs 
        /// </summary>
        public Guid? UnitOfMeasurementId { get; set; }

        /// <summary>
        /// Navigation property representing the associated UnitOfMeasurement
        /// </summary>
        [ForeignKey("UnitOfMeasurementId")]
        public UnitOfMeasurement? UnitOfMeasurementId_UnitOfMeasurement { get; set; }
        /// <summary>
        /// Foreign key referencing the InventoryReport to which the StockMovement belongs 
        /// </summary>
        public Guid? InventoryReportId { get; set; }

        /// <summary>
        /// Navigation property representing the associated InventoryReport
        /// </summary>
        [ForeignKey("InventoryReportId")]
        public InventoryReport? InventoryReportId_InventoryReport { get; set; }
        /// <summary>
        /// Quantity of the StockMovement 
        /// </summary>
        public int? Quantity { get; set; }

        /// <summary>
        /// CreatedOn of the StockMovement 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the StockMovement 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the StockMovement 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the StockMovement 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}