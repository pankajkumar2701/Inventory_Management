using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InventoryManagement.Entities
{
    /// <summary> 
    /// Represents a shippingaddress entity with essential details
    /// </summary>
    public class ShippingAddress
    {
        /// <summary>
        /// TenantId of the ShippingAddress 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ShippingAddress 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Code of the ShippingAddress 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the ShippingAddress 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// AddressLine1 of the ShippingAddress 
        /// </summary>
        public string? AddressLine1 { get; set; }
        /// <summary>
        /// AddressLine2 of the ShippingAddress 
        /// </summary>
        public string? AddressLine2 { get; set; }
        /// <summary>
        /// City of the ShippingAddress 
        /// </summary>
        public string? City { get; set; }
        /// <summary>
        /// State of the ShippingAddress 
        /// </summary>
        public string? State { get; set; }
        /// <summary>
        /// Country of the ShippingAddress 
        /// </summary>
        public string? Country { get; set; }
        /// <summary>
        /// PostalCode of the ShippingAddress 
        /// </summary>
        public string? PostalCode { get; set; }

        /// <summary>
        /// CreatedOn of the ShippingAddress 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the ShippingAddress 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ShippingAddress 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ShippingAddress 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
    }
}