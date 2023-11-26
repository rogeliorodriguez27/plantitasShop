using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Domain.Common;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace Ecommerce.Domain;

public class OrderAddress : BaseDomainModel{
[Column(TypeName = "NVARCHAR(4000)") ]
    public string? AddressText { get; set; }
    

    public string? City { get; set; }
    public string? State { get; set; }
    public string? PostalCode { get; set; }
    public string? Username { get; set; }
    public string? Country { get; set; }
    public Order? Order{ get; set; } 

}
 