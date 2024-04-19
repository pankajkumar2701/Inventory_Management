using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagement.Entities
{
    /// <summary> 
    /// Represents a ordernote entity with essential details
    /// </summary>
    public class OrderNote
    {
        /// <summary>
        /// TenantId of the OrderNote 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the OrderNote 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the OrderNote 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the OrderNote 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Note of the OrderNote 
        /// </summary>
        public string? Note { get; set; }

        /// <summary>
        /// CreatedOn of the OrderNote 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the OrderNote 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the OrderNote 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the OrderNote 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}