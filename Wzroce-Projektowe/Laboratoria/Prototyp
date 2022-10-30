using System;
using System.Collections.Generic;

public abstract class ProductPrototype
{
    public decimal Price { get; set; }

    public ProductPrototype(decimal price)
    {
        Price = price;
    }

    public ProductPrototype Clone()
    {
        return (ProductPrototype)this.MemberwiseClone();
    }
}

public class Bread : ProductPrototype
{
    public Bread(decimal price) : base(price)
    {
    }
}

public class Butter : ProductPrototype
{
    public Butter(decimal price) : base(price)
    {
    }
}

public class Supermarket
{
    private Dictionary<string, ProductPrototype> _productList = new Dictionary<string, ProductPrototype>();

    public void AddProduct(string key, ProductPrototype productPrototype)
    {
        _productList.Add(key, productPrototype);
    }

    public ProductPrototype GetClonedProduct(string key)
    {
        var product = _productList[key];
        return product.Clone();
    }
}

internal class MainClass
{
    public static void Main(string[] args)
    {
        var supermarket = new Supermarket();
        ProductPrototype product;

        supermarket.AddProduct("Bread", new Bread(9.50m));
        supermarket.AddProduct("Butter", new Butter(5.30m));

        product = supermarket.GetClonedProduct("Bread");
        Console.WriteLine(String.Format("Bread - {0} zł", product.Price));
        product = supermarket.GetClonedProduct("Butter");
        Console.WriteLine(String.Format("Butter - {0} zł", product.Price));
    }
}
