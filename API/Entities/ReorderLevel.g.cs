using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagement.Entities
{
    /// <summary> 
    /// Represents a reorderlevel entity with essential details
    /// </summary>
    public class ReorderLevel
    {
        /// <summary>
        /// TenantId of the ReorderLevel 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ReorderLevel 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the ReorderLevel 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the ReorderLevel 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// MinimumValue of the ReorderLevel 
        /// </summary>
        public int? MinimumValue { get; set; }
        /// <summary>
        /// MaximumValue of the ReorderLevel 
        /// </summary>
        public int? MaximumValue { get; set; }

        /// <summary>
        /// CreatedOn of the ReorderLevel 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ReorderLevel 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ReorderLevel 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ReorderLevel 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}