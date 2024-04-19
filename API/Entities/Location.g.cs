using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagement.Entities
{
    /// <summary> 
    /// Represents a location entity with essential details
    /// </summary>
    public class Location
    {
        /// <summary>
        /// TenantId of the Location 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Location 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the Location 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the Location 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Warehouse to which the Location belongs 
        /// </summary>
        public Guid? WarehouseId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Warehouse
        /// </summary>
        [ForeignKey("WarehouseId")]
        public Warehouse? WarehouseId_Warehouse { get; set; }

        /// <summary>
        /// CreatedOn of the Location 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Location 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Location 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Location 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}