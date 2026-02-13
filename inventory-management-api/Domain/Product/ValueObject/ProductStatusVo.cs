namespace Domain.Product.ValueObject;

public abstract class ProductStatusVo
{
    protected ProductStatusVo(int status)
    {
        //     Active = 1,
        // Inactive = 0,
        // Deleted = -1,
        // Disconnect = -2,
        // Discontinued = 2
        switch (status)
        {
            case 1:
                break;
            case 0:

                break;
        }

        Value = status;
    }

    public int Value { get; }
}