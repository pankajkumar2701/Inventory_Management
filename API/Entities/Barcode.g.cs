using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagement.Entities
{
    /// <summary> 
    /// Represents a barcode entity with essential details
    /// </summary>
    public class Barcode
    {
        /// <summary>
        /// TenantId of the Barcode 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Barcode 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the Barcode 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the Barcode 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Format of the Barcode 
        /// </summary>
        public string? Format { get; set; }
        /// <summary>
        /// Value of the Barcode 
        /// </summary>
        public string? Value { get; set; }

        /// <summary>
        /// CreatedOn of the Barcode 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Barcode 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Barcode 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Barcode 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}