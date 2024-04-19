using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagement.Entities
{
    /// <summary> 
    /// Represents a customer entity with essential details
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// TenantId of the Customer 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Customer 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the Customer 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the Customer 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// CreatedOn of the Customer 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Customer 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Customer 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Customer 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}