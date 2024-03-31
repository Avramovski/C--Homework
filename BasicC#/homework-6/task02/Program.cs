// See https://aka.ms/new-console-template for more information
using Domain;
using Domain.Enums;
using System.Collections;
using System.Collections.Generic;
static void PrintColectionItems(IEnumerable colection)
{
    foreach (var item in colection)
    {
        Console.WriteLine($"{item}");
    }
}
// Data Sample
List<Product> products = new List<Product>()
{
    new Product(1, "iPhone 9", "An apple mobile which is nothing like apple", 549, 4.69, 94, "Apple", ProductCategory.Smartphones),
    new Product(2, "iPhone X", "SIM-Free, Model A19211 6.5-inch Super Retina HD display with OLED technology A12 Bionic chip with ...", 899, 4.44, 34, "Apple", ProductCategory.Smartphones),
    new Product(3, "Samsung Universe 9", "Samsung's new variant which goes beyond Galaxy to the Universe", 1249, 4.09, 36, "Samsung", ProductCategory.Smartphones),
    new Product(4, "OPPOF19", "OPPO F19 is officially announced on April 2021.", 280, 4.3, 123, "OPPO", ProductCategory.Smartphones),
    new Product(5, "Huawei P30", "Huawei’s re-badged P30 Pro New Edition was officially unveiled yesterday in Germany and now the device has made its way to the UK.", 499, 4.09, 32, "Huawei", ProductCategory.Smartphones),
    new Product(6, "MacBook Pro", "MacBook Pro 2021 with mini-LED display may launch between September, November", 1749, 4.57, 83, "Apple", ProductCategory.Laptops),
    new Product(7, "Samsung Galaxy Book", "Samsung Galaxy Book S (2020) Laptop With Intel Lakefield Chip, 8GB of RAM Launched", 1499, 4.25, 50, "Samsung", ProductCategory.Laptops),
    new Product(8, "Microsoft Surface Laptop 4", "Style and speed. Stand out on HD video calls backed by Studio Mics. Capture ideas on the vibrant touchscreen.", 1499, 4.43, 68, "Microsoft Surface", ProductCategory.Laptops),
    new Product(9, "Infinix INBOOK", "Infinix Inbook X1 Ci3 10th 8GB 256GB 14 Win10 Grey – 1 Year Warranty", 1099, 4.54, 96, "Infinix", ProductCategory.Laptops),
    new Product(10, "HP Pavilion 15-DK1056WM", "HP Pavilion 15-DK1056WM Gaming Laptop 10th Gen Core i5, 8GB, 256GB SSD, GTX 1650 4GB, Windows 10", 1099, 4.43, 89, "HP Pavilion", ProductCategory.Laptops),
    new Product(11, "perfume Oil", "Mega Discount, Impression of Acqua Di Gio by GiorgioArmani concentrated attar perfume Oil", 13, 4.26, 65, "Impression of Acqua Di Gio", ProductCategory.Fragrances),
    new Product(12, "Brown Perfume", "Royal_Mirage Sport Brown Perfume for Men & Women - 120ml", 40, 4, 52, "Royal_Mirage", ProductCategory.Fragrances),
    new Product(13, "Fog Scent Xpressio Perfume", "Product details of Best Fog Scent Xpressio Perfume 100ml For Men cool long lasting perfumes for Men", 13, 4.59, 61, "Fog Scent Xpressio", ProductCategory.Fragrances),
    new Product(14, "Non-Alcoholic Concentrated Perfume Oil", "Original Al Munakh® by Mahal Al Musk | Our Impression of Climate | 6ml Non-Alcoholic Concentrated Perfume Oil", 120, 4.21, 114, "Al Munakh", ProductCategory.Fragrances),
    new Product(15, "Eau De Perfume Spray", "Genuine  Al-Rehab spray perfume from UAE/Saudi Arabia/Yemen High Quality", 30, 4.7, 105, "Lord - Al-Rehab", ProductCategory.Fragrances),
    new Product(16, "Hyaluronic Acid Serum", "L'OrÃ©al Paris introduces Hyaluron Expert Replumping Serum formulated with 1.5% Hyaluronic Acid", 19, 4.83, 110, "L'Oreal Paris", ProductCategory.Skincare),
    new Product(17, "Tree Oil 30ml", "Tea tree oil contains a number of compounds, including terpinen-4-ol, that have been shown to kill certain bacteria,", 12, 4.52, 78, "Hemani Tea", ProductCategory.Skincare),
    new Product(18, "Oil Free Moisturizer 100ml", "Dermive Oil Free Moisturizer with SPF 20 is specifically formulated with ceramides, hyaluronic acid & sunscreen.", 40, 4.56, 88, "Dermive", ProductCategory.Skincare),
    new Product(19, "Skin Beauty Serum.", "Product name: rorec collagen hyaluronic acid white face serum riceNet weight: 15 m", 46, 4.42, 54, "ROREC White Rice", ProductCategory.Skincare),
    new Product(20, "Freckle Treatment Cream- 15gm", "Fair & Clear is Pakistan's only pure Freckle cream which helpsfade Freckles, Darkspots and pigments. Mercury level is 0%, so there are no side effects.", 70, 4.06, 140, "Fair & Clear", ProductCategory.Skincare),
    new Product(21, "- Daal Masoor 500 grams", "Fine quality Branded Product Keep in a cool and dry place", 20, 4.44, 133, "Saaf & Khaas", ProductCategory.Groceries),
    new Product(22, "Elbow Macaroni - 400 gm", "Product details of Bake Parlor Big Elbow Macaroni - 400 gm", 14, 4.57, 146, "Bake Parlor Big", ProductCategory.Groceries),
    new Product(23, "Orange Essence Food Flavou", "Specifications of Orange Essence Food Flavour For Cakes and Baking Food Item", 14, 4.85, 26, "Baking Food Items", ProductCategory.Groceries)
};

//Retrieve all products with a price greater than $500.
Console.WriteLine("Products with a price greater than $500");
List<Product> greaterThen500 = products.Where(product => product.Price > 500).ToList();
foreach (Product product in greaterThen500)
{
    Console.WriteLine($"Title: {product.Title} pric:{product.Price}");
}

Console.WriteLine("\n\nSkincare Products:");

List<Product> skincareProducts = products
         .Where(product => product.Category == ProductCategory.Skincare)
         .ToList();
foreach (Product product in skincareProducts)
{
    Console.WriteLine($"Title: {product.Title}");
}

List<string> alltitles = products.Select(product => product.Title).ToList();
Console.WriteLine("\n\nAll titles");
foreach (string title in alltitles)
{
    Console.WriteLine(title);

}
Console.WriteLine("\n\nall laptops");
List<string> laptop = products.Where(product => product.Category == ProductCategory.Laptops).Select(product => product.Title).ToList();
foreach (string title in laptop)
{
    Console.WriteLine($"Title: {title}");
}

List<string> stocklessThen50 = products.Where(product => product.Stock < 50).Select(product => product.Description).ToList();
Console.WriteLine("\n\nLess then 50 stock discriptions:");
foreach (string discription in stocklessThen50)
{
    Console.WriteLine(discription);
}

List<string> ratingAbove = products.Where(product => product.Rating > 4.5).Select(product => product.Title).ToList();
Console.WriteLine("\n\n All products with rating above 4.5");
foreach (string title in ratingAbove)
{
    Console.WriteLine(title);
}

List<string> productsBetwen100i200 = products.Where(products => products.Price > 100 && products.Price <     200).Select(product => product.Title).ToList();
Console.WriteLine("\n\nprice between $100 and $200.");
foreach (string title in productsBetwen100i200)
{
    Console.WriteLine(title);
}

List<string> FragrancesWithRating = products.Where(product => product.Rating > 4.6 && product.Category == ProductCategory.Fragrances)
    .Select(product => product.Title).ToList();
Console.WriteLine("\n\nFragrances category with a rating above 4.6.");
foreach (string title in FragrancesWithRating)
{
    Console.WriteLine(title);
}

//Retrieve the brands of all products with a price above $1000.


List<string> productAbove1000 = products.Where(product => product.Price > 1000).Select(product => product.Brand).ToList();

Console.WriteLine("\n\n brands of all products with a price above $1000.");

foreach (string title in productAbove1000)
{
    Console.WriteLine(title);
}
//Select the titles of all products with the word "perfume" in the title.

List<Product> perfumeInTitle = products.Where(product => product.Title.Contains("perfume")).ToList();
Console.WriteLine("\n\nproducts with the word \"perfume\" in the title.");
foreach (Product product in perfumeInTitle)
{
    Console.WriteLine(product.Title);
}

Product lastGrocaryProduct =
    products.LastOrDefault(product => product.Category == ProductCategory.Groceries);

Console.WriteLine("\n\n" + lastGrocaryProduct.Title);

//Find the first product with a price above $1000.

Product firstAbove1000 = products.FirstOrDefault(product => product.Price > 1000);
Console.WriteLine("\n\n" + firstAbove1000.Title);


//Select the titles of all products from the "Groceries" category with a stock above 150.


List <string> croceriesAbove150 = products.Where(product => product.Category == ProductCategory.Groceries && product.Stock > 150)
    .Select(product => product.Title).ToList();
Console.WriteLine("\n\nGroceries category with a stock above 150.");
foreach (string title in croceriesAbove150)
{
    Console.WriteLine(title);
}
//Find the first item from the brand "Hemani Tea".

Product task14 = products.FirstOrDefault(product => product.Brand == "Hemani Tea");

Console.WriteLine($"\n\nfirst item from the brand \"Hemani Tea is: {task14.Title}" );


//Retrieve the ratings of all products with a stock between 30 and 50.

Console.WriteLine("\n\nproducts with a stock between 30 and 50.");
List<Product> stockBetween30And50 = products.Where(product => product.Stock >= 30  && product.Stock <= 50).ToList();
foreach (Product product in stockBetween30And50)
{
    Console.WriteLine(product.Rating);
}

double averagePrice = products
           .Average(product => product.Price);

Console.WriteLine($"Average Price of All Products: ${averagePrice}\n\n");

double totalStock = products.Select(product => product.Stock).Sum();
Console.WriteLine("total stock of all products:" +totalStock);

Console.WriteLine("With price above 2000:");
List<string> priceAbove2000 = products.Where(product => product.Price > 2000).Select(product => product.Title).ToList();
foreach (string product in priceAbove2000)
{
    Console.WriteLine(product);
}

Product mostExpensiveLaptop = products
            .Where(product => product.Category == ProductCategory.Laptops)
            .OrderByDescending(product => product.Price)
            .FirstOrDefault();

Console.WriteLine("\n\nmost expensive Laptop" + mostExpensiveLaptop.Title );

List<Product> allSkincareProducts = products
         .Where(product => product.Category == ProductCategory.Skincare)
         .ToList();
Console.WriteLine("\nScincare products :");
foreach (Product product in skincareProducts)
{
    Console.WriteLine($"Title: {product.Title}\n Brand: {product.Brand}");
}