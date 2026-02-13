using Domain.Product.ValueObject;

namespace Domain.Product.Entity;

public class Product
{
    public int Id { get; private set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Barcode { get; set; } 
    public decimal SalePrice { get; set; }
    public decimal PurchasePrice { get; set; }
    public int Stock { get; set; }
    public int MinStock { get; set; }
    public int MaxStock { get; set; }
    public int Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    private Product()
    {
        
    }
    public Product(ProductNameVo productName, ProductDescriptionVo productDescription,ProductBarCodeVo productBarCodeVo ,ProductSalePriceVo productSalePriceVo, ProductPurchasePriceVo productPurchasePriceVo, ProductStockVo productStockVo, int minStock, int maxStock, ProductStatusVo status)
    {
        Name = productName.Value;
        Description = productDescription.Value;
        Barcode = productBarCodeVo.Value;
        SalePrice = productSalePriceVo.Value;
        PurchasePrice = productPurchasePriceVo.Value;
        Stock = productStockVo.Value;
        MinStock = minStock;
        MaxStock = maxStock;
        Status = status.Value;
    }
}