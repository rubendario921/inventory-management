namespace Domain.Product.ValueObject;

public abstract class ProductSalePriceVo{
    protected ProductSalePriceVo(decimal salePrice)
    {
   if(salePrice <0) throw new ArgumentException("The selling price must be greater than 0 ",nameof(salePrice));
       
        Value = salePrice;
    }

    public string Value { get; }
}