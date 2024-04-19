using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagement.Entities
{
    /// <summary> 
    /// Represents a lotnumber entity with essential details
    /// </summary>
    public class LotNumber
    {
        /// <summary>
        /// TenantId of the LotNumber 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the LotNumber 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the LotNumber 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the LotNumber 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// CreatedOn of the LotNumber 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the LotNumber 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the LotNumber 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the LotNumber 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}