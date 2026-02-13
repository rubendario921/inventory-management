namespace Domain.Product.ValueObject;
public abstract class ProductStockVo{
    protected ProductStockVo(decimal stock){
           if(stock <0) throw new ArgumentException("The selling price must be greater than 0 ",nameof(stock));
           Value = stock;
    }
    public string Value {get;}
}