namespace Domain.Product.ValueObject;

public abstract class ProductNameVo
{
    protected ProductNameVo(string name)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name is required", nameof(name));
        if (name.Length > 20) throw new ArgumentException("Name must be less than 20 characters", nameof(name));
        if (!System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z ]+$"))
            throw new ArgumentException("Name must be letters", nameof(name));
        Value = name;
    }

    public string Value { get; }
}