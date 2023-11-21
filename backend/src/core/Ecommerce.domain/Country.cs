using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Domain.Common;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace Ecommerce.Domain;

public class Country : BaseDomainModel{
[Column(TypeName = "NVARCHAR(4000)") ]
    public string? Name { get; set; }
    

    public string? Iso2 { get; set; }
    public string? Iso3 { get; set; }

}
