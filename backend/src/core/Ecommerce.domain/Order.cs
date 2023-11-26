 using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Domain.Common;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace Ecommerce.Domain;

public class Order : BaseDomainModel{
public Order(){}

public Order(
    string buyerName,
    string buyerEmail,
    OrderAddress orderAddress,
    decimal subtotal,
    decimal total,
    decimal tax,
    decimal priceShipping
){
    BuyerName = buyerName;
    BuyerUsername = buyerEmail;
    OrderAddress = orderAddress;
    Subtotal = subtotal;
    Total = total;
    Tax = tax;
    Shipping = priceShipping;

}
    public string? BuyerName { get; set; }
    

    public string? BuyerUsername { get; set; }
    public OrderAddress? OrderAddress { get; set; }
    public IReadOnlyList<OrderItem>? OrderItems { get; set; }
 [Column(TypeName = "decimal(10,2)") ]
   public decimal Subtotal { get; set; }
    public OrderStatus Status { get; set; } = OrderStatus.Pending;

 [Column(TypeName = "decimal(10,2)") ]
   public decimal Total { get; set; }

 [Column(TypeName = "decimal(10,2)") ]
   public decimal Tax { get; set; }
 [Column(TypeName = "decimal(10,2)") ]
   public decimal Shipping { get; set; }
   public string? PaymemtIntentId { get; set; }
  public string? ClientSecret { get; set; }
  public string? StripeApiKey { get; set; }

}
