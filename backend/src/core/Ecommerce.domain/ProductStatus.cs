using System.Runtime.Serialization;

namespace Ecommerce.Domain;
public enum ProductStatus
{
 [EnumMember(Value ="product inactive")]
 Inactive,
  [EnumMember(Value ="product inactive")]   
Active,   
}