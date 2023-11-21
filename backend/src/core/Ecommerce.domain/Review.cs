using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Domain.Common;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace Ecommerce.Domain;

public class Review : BaseDomainModel{
[Column(TypeName = "NVARCHAR(30)") ]
    public string? Name { get; set; }
    public int Rating { get; set; }
    [Column(TypeName = "NVARCHAR(180)") ]

    public string? ReviewText { get; set; }
    public int ProductId { get; set; }

}
