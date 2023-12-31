using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Domain.Common;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace Ecommerce.Domain;

public class OrderItem : BaseDomainModel{
    public Product? Product { get; set; }
    public int ProductId { get; set; }


    public decimal? Price { get; set; }
    public int Quantity { get; set; }
    public Order? Order { get; set; }
    public int OrderId { get; set; }

    public int ProductItemId { get; set; }
    public string? ProductName { get; set; }
    public string? ImageUrl { get; set; }


}
