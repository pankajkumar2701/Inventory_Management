using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagement.Entities
{
    /// <summary> 
    /// Represents a unitofmeasurement entity with essential details
    /// </summary>
    public class UnitOfMeasurement
    {
        /// <summary>
        /// TenantId of the UnitOfMeasurement 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the UnitOfMeasurement 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the UnitOfMeasurement 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the UnitOfMeasurement 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// CreatedOn of the UnitOfMeasurement 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the UnitOfMeasurement 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the UnitOfMeasurement 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the UnitOfMeasurement 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}