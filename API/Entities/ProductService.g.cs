using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagement.Entities
{
    /// <summary> 
    /// Represents a productservice entity with essential details
    /// </summary>
    public class ProductService
    {
        /// <summary>
        /// TenantId of the ProductService 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ProductService 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the ProductService 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the ProductService 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// CreatedOn of the ProductService 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ProductService 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ProductService 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ProductService 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}