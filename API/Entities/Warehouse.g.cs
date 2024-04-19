using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagement.Entities
{
    /// <summary> 
    /// Represents a warehouse entity with essential details
    /// </summary>
    public class Warehouse
    {
        /// <summary>
        /// TenantId of the Warehouse 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Warehouse 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the Warehouse 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the Warehouse 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// CreatedOn of the Warehouse 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Warehouse 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Warehouse 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Warehouse 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}