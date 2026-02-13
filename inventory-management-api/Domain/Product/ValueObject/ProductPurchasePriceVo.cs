namespace Domain.Product.ValueObject;

public abstract class ProductPurchasePriceVo{
    protected ProductPurchasePriceVo(decimal purchasePrice){
           if(purchasePrice <0) throw new ArgumentException("The selling price must be greater than 0 ",nameof(purchasePrice));
           Value = purchasePrice;
    }
    public string Value {get;}
}