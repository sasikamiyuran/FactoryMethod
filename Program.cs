using Implementation;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var factories = new List<DiscountFactory>{
    new CountryDiscountFactory("LK"),
    new CodeDiscountFactory(Guid.NewGuid().ToString())
};

foreach (var factory in factories)
{
    var discountService = factory.CreateDiscountService();
    Console.WriteLine($"Percentage {discountService.DiscountPercentation} comming from {discountService}");
}
