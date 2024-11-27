using System.Collections.Generic;

public class Category {
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public string Description { get; set; }
    public List<Product> Products { get; set; }
}

public class Product {
    public string ProductName { get; set; }
    public double UnitPrice { get; set; }
}

public static class CategoryProductDataSource {
    public static List<Category> GetData() {
        return new List<Category>
        {
                new Category()
                {
                    CategoryName = "Beverages",
                    Description = "Soft drinks, coffees, teas, beers, and ales",
                    Products = new List<Product>
                    {
                        new Product{ ProductName = "Chai", UnitPrice = 18 },
                        new Product{ ProductName = "Chang", UnitPrice = 19 },
                        new Product{ ProductName = "Guaraná Fantástica", UnitPrice = 4.5 }
                    },
                },

                new Category()
                {
                    CategoryName = "Condiments",
                    Description = "Sweet and savory sauces, relishes, spreads, and seasonings",
                    Products = new List<Product>
                    {
                        new Product{ ProductName = "Aniseed Syrup", UnitPrice = 10 },
                        new Product{ ProductName = "Chef Anton's Cajun Seasoning", UnitPrice = 22 },
                        new Product{ ProductName = "Chef Anton's Gumbo Mix", UnitPrice = 21.35 },
                        new Product{ ProductName = "Grandma's Boysenberry Spread", UnitPrice = 25 }
                    },
                },

                new Category()
                {
                    CategoryName = "Confections",
                    Description = "Desserts, candies, and sweet breads",
                    Products = new List<Product>
                    {
                        new Product{ ProductName = "Pavlova", UnitPrice = 17.45 },
                        new Product{ ProductName = "Teatime Chocolate Biscuits", UnitPrice = 9.2 },
                        new Product{ ProductName = "Sir Rodney's Marmalade", UnitPrice = 81 },
                        new Product{ ProductName = "Sir Rodney's Scones", UnitPrice = 10 },
                        new Product{ ProductName = "NuNuCa Nuß-Nougat-Creme", UnitPrice = 14 },
                    },
                }
            };
    }
}
