namespace Domain.Product.ValueObject;

public abstract class ProductDescriptionVo
{
    protected ProductDescriptionVo(string description)
    {
        if (string.IsNullOrWhiteSpace(description))
            throw new ArgumentException("Description is required", nameof(description));
        if (description.Length > 200)
            throw new ArgumentException("Description must be less than 200 characters", nameof(description));
        if (!System.Text.RegularExpressions.Regex.IsMatch(description, @"^[a-zA-Z0-9 ]+$"))
            throw new ArgumentException("Description must be letters and numbers", nameof(description));

        Value = description;
    }

    public string Value { get; }
}