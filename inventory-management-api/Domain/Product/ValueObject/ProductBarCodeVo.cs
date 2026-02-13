namespace Domain.Product.ValueObject;

public abstract class ProductBarCodeVo
{
    protected ProductBarCodeVo(string barCode){
        if(string.IsNullOrWhiteSpace(barCode)) throw new ArgumentException("BarCode is required", nameof(barCode));
        Value = barCode;
    }
    public string Value {get;}
}