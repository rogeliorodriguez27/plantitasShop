using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Domain.Common;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace Ecommerce.Domain;

public class ShoppingCartItem : BaseDomainModel{
    public string? Product { get; set; }
[Column(TypeName = "decimal(10,2)") ]
    public decimal Price { get; set; }
    
    public int Quantity { get; set; }

    public string? Image { get; set; }

    public string? Category { get; set; }

    public Guid? ShoppingCartMasterId { get; set; }

    public int ShoppingCartId { get; set; }

    public int ProductID { get; set; }

    public int Stock { get; set; }

}
