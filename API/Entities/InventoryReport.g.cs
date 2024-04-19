using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagement.Entities
{
    /// <summary> 
    /// Represents a inventoryreport entity with essential details
    /// </summary>
    public class InventoryReport
    {
        /// <summary>
        /// TenantId of the InventoryReport 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the InventoryReport 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the InventoryReport 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the InventoryReport 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Date of the InventoryReport 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// CreatedOn of the InventoryReport 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the InventoryReport 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the InventoryReport 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the InventoryReport 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}