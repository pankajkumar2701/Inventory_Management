using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagement.Entities
{
    /// <summary> 
    /// Represents a expirationdate entity with essential details
    /// </summary>
    public class ExpirationDate
    {
        /// <summary>
        /// TenantId of the ExpirationDate 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ExpirationDate 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the ExpirationDate 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the ExpirationDate 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Date of the ExpirationDate 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// CreatedOn of the ExpirationDate 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ExpirationDate 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ExpirationDate 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ExpirationDate 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}