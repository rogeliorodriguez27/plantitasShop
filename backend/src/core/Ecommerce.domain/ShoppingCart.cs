using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Domain.Common;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace Ecommerce.Domain;

public class ShoppingCart : BaseDomainModel{
    public Guid? ShoppingCartMasterId { get; set; }  
    public virtual ICollection<ShoppingCartItem>? ShoppingCartItems { get; set; }

}
