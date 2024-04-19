using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagement.Entities
{
    /// <summary> 
    /// Represents a demandforecasting entity with essential details
    /// </summary>
    public class DemandForecasting
    {
        /// <summary>
        /// TenantId of the DemandForecasting 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the DemandForecasting 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the DemandForecasting 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the DemandForecasting 
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// StartDate of the DemandForecasting 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// EndDate of the DemandForecasting 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// ForecastQuantity of the DemandForecasting 
        /// </summary>
        public int? ForecastQuantity { get; set; }

        /// <summary>
        /// CreatedOn of the DemandForecasting 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the DemandForecasting 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the DemandForecasting 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the DemandForecasting 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}