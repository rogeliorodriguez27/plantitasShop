using System.ComponentModel.DataAnnotations.Schema;
using  Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class Product : BaseDomainModel{
[Column(TypeName = "NVARCHAR(100)") ]

    public string? Name { get; set; }
    [Column(TypeName = "DECIMAL(10,2)") ]

    public decimal Price { get; set; }
[Column(TypeName = "NVARCHAR(4000)") ]

    public string? Description { get; set; }
    public int rating { get; set; }
[Column(TypeName = "NVARCHAR(30)") ]

    public string? Vendor { get; set; }
    public int stock { get; set; }
    public ProductStatus Status { get; set; } = ProductStatus.Active;
    public int CategoryId { get; set; }

}
