using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagement.Entities
{
    /// <summary> 
    /// Represents a return entity with essential details
    /// </summary>
    public class Return
    {
        /// <summary>
        /// TenantId of the Return 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Return 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the Return 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the Return 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Reason of the Return 
        /// </summary>
        public string? Reason { get; set; }
        /// <summary>
        /// Status of the Return 
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// CreatedOn of the Return 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Return 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Return 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Return 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}