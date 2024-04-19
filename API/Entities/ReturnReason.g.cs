using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagement.Entities
{
    /// <summary> 
    /// Represents a returnreason entity with essential details
    /// </summary>
    public class ReturnReason
    {
        /// <summary>
        /// TenantId of the ReturnReason 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ReturnReason 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the ReturnReason 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the ReturnReason 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// CreatedOn of the ReturnReason 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ReturnReason 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ReturnReason 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ReturnReason 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}