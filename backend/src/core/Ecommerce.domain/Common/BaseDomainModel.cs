namespace Ecommerce.Domain.Common;

public abstract class BaseDomainModel{
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModificatedDate { get; set; }

    public string? LastModificatedBy { get; set; }



} 