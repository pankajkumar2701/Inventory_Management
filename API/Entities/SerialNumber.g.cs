using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagement.Entities
{
    /// <summary> 
    /// Represents a serialnumber entity with essential details
    /// </summary>
    public class SerialNumber
    {
        /// <summary>
        /// TenantId of the SerialNumber 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the SerialNumber 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the SerialNumber 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the SerialNumber 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Number of the SerialNumber 
        /// </summary>
        public string? Number { get; set; }

        /// <summary>
        /// CreatedOn of the SerialNumber 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the SerialNumber 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the SerialNumber 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the SerialNumber 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}