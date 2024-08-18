namespace C42_G02_LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //-1
            var result = productlist.where(p => p.unitsinstock == 0)
                        .tolist();
            foreach (var item in result)
            {
                console.writeline(item);
            }

            //-2
            var Result = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M)
                         .ToList();
            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }

            //-3
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var Result = Arr.Select((name, index) => new { Name = name, Value = index })
                         .Where(x => x.Name.Length < x.Value)
                         .ToList();
            foreach (var item in Result)
            {
                Console.WriteLine(item.Name);
            }
            #endregion

            #region 2
            //-1
            var Result = ProductList.FirstOrDefault(P => P.UnitsInStock == 0);
            if (Result != null)
            {
                Console.WriteLine(Result.ProductName);
            }
            else
            {
                Console.WriteLine("No out-of-stack products found");
            }

            //-2
            var Result = ProductList.FirstOrDefault(P => P.UnitPrice > 1000);
            if (Result == null) { Console.WriteLine(Result.ProductName); }
            else { Console.WriteLine("No products with price greater than 1000 found."); 
            }

            //-3
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var Result = Arr
                    .Where(n => n > 5)
                    .Skip(1)
                    .FirstOrDefault();
            Console.WriteLine(Result);
            #endregion

            #region 3
            //-1
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddCount = Arr.Count(n => n % 2 != 0);
            Console.WriteLine($"Number of odd numbers: {oddCount}");

            //-2
            var customerOrderCounts = CustomerList
                   .Select(c => new
                   {
                    CustomerName = c.CustomerName,
                    OrderCount = c.Orders.Count()
                   })
                   .ToList();
            foreach (var customer in customerOrderCounts)
            {
                Console.WriteLine($"{customer.CustomerName} has {customer.OrderCount} orders.");
            }

            //-3
            var categoryProductCounts = ProductList
                 .GroupBy(p => p.Category)
                 .Select(g => new
                 {
                  CategoryName = g.Key,
                  ProductCount = g.Count()
                 })
                 .ToList();
            foreach (var category in categoryProductCounts)
            {
                Console.WriteLine($"{category.CategoryName} has {category.ProductCount} products.");
            }

            //-4
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int totalSum = Arr.Sum();
            Console.WriteLine($"Total sum: {totalSum}");

            //-5
            string[] dictionaryWords = File.ReadAllLines("dictionary_english.txt");
            int totalCharacters = dictionaryWords.Sum(word => word.Length);
            Console.WriteLine($"Total number of characters: {totalCharacters}");

            //-6
            int shortestWordLength = dictionaryWords.Min(word => word.Length);
            Console.WriteLine($"Length of the shortest word: {shortestWordLength}");

            //-7
            int longestWordLength = dictionaryWords.Max(word => word.Length);
            Console.WriteLine($"Length of the longest word: {longestWordLength}");

            //-8
            double averageWordLength = dictionaryWords.Average(word => word.Length);
            Console.WriteLine($"Average word length: {averageWordLength}");

            //-9
            var totalUnitsInStockByCategory = ProductList
                    .GroupBy(p => p.Category)
                    .Select(g => new
                    {
                      CategoryName = g.Key,
                      TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
                    })
                   .ToList();
            foreach (var category in totalUnitsInStockByCategory)
            {
             Console.WriteLine($"{category.CategoryName} has {category.TotalUnitsInStock} units in stock.");
            }

            //-10
            var cheapestPriceByCategory = ProductList
                    .GroupBy(p => p.Category)
                    .Select(g => new
                    {
                     CategoryName = g.Key,
                     CheapestPrice = g.Min(p => p.UnitPrice)
                    })
                    .ToList();

            foreach (var category in cheapestPriceByCategory)
            {
             Console.WriteLine($"{category.CategoryName} has a minimum price of {category.CheapestPrice}");
            }

            //-12
            var mostExpensivePriceByCategory = ProductList
                     .GroupBy(p => p.Category)
                     .Select(g => new
                     {
                      CategoryName = g.Key,
                      MostExpensivePrice = g.Max(p => p.UnitPrice)
                     })
                     .ToList();
            foreach (var category in mostExpensivePriceByCategory)
            {
             Console.WriteLine($"{category.CategoryName} has a maximum price of {category.MostExpensivePrice}");
            }

            //-14
            var averagePriceByCategory = ProductList
                 .GroupBy(p => p.Category)
                 .Select(g => new
                 {
                  CategoryName = g.Key,
                  AveragePrice = g.Average(p => p.UnitPrice)
                 })
                 .ToList();
            foreach (var category in averagePriceByCategory)
            {
             Console.WriteLine($"{category.CategoryName} has an average price of {category.AveragePrice}");
            }
            #endregion

            #region 4
            //-1
            var productsSortedByName = ProductList
                   .OrderBy(p => p.ProductName)
                   .ToList();
            foreach (var product in productsSortedByName)
            {
             Console.WriteLine(product.ProductName);
            }

            //-2
             string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortedWords = Arr
                    .OrderBy(word => word, StringComparer.OrdinalIgnoreCase)
                    .ToList();
            foreach (var word in sortedWords)
            {
             Console.WriteLine(word);
            }

            //-3
            var productsSortedByUnitsInStock = ProductList
                  .OrderByDescending(p => p.UnitsInStock)
                  .ToList();
            foreach (var product in productsSortedByUnitsInStock)
            {
             Console.WriteLine($"{product.ProductName} - Units in Stock: {product.UnitsInStock}");
            }

            //-4
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var sortedDigits = Arr
                 .OrderBy(digit => digit.Length)
                 .ThenBy(digit => digit)
                 .ToList();
            foreach (var digit in sortedDigits)
            {
             Console.WriteLine(digit);
            }

            //-5
            string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedWords = Arr
                 .OrderBy(word => word.Length)
                 .ThenBy(word => word, StringComparer.OrdinalIgnoreCase)
                 .ToList();
            foreach (var word in sortedWords)
            {
             Console.WriteLine(word);
            }

            //-6
            var productsSortedByCategoryAndPrice = ProductList
                      .OrderBy(p => p.Category)
                      .ThenByDescending(p => p.UnitPrice)
                      .ToList();
            foreach (var product in productsSortedByCategoryAndPrice)
            {
             Console.WriteLine($"{product.Category} - {product.ProductName} - Price: {product.UnitPrice}");
            }

            //-7
            string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortedWords = Arr
                   .OrderBy(word => word.Length)
                   .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase)
                   .ToList();
            foreach (var word in sortedWords)
            {
             Console.WriteLine(word);
            }
            #endregion

            #region 5
            //-1
            var productNames = ProductList
                   .Select(p => p.ProductName)
                   .ToList();
            foreach (var name in productNames)
            {
             Console.WriteLine(name);
            }

            //-2
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            var wordCases = words
                  .Select(word => new
                  {
                    UpperCase = word.ToUpper(),
                    LowerCase = word.ToLower()
                   })
                   .ToList();
            foreach (var word in wordCases)
            {
             Console.WriteLine($"Uppercase: {word.UpperCase}, Lowercase: {word.LowerCase}");
            }

            //-3
            var productDetails = ProductList
                     .Select(p => new
                     {
                         p.ProductName,
                         Price = p.UnitPrice,
                         p.Category
                     })
                     .ToList();
            foreach (var product in productDetails)
            {
             Console.WriteLine($"Name: {product.ProductName}, Price: {product.Price}, Category: {product.Category}");
            }

            //-4
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var valuePositionMatch = Arr
                      .Select((value, index) => new
                      {
                       Value = value,
                       MatchesPosition = value == index
                      })
                      .ToList();
            foreach (var item in valuePositionMatch)
            {
             Console.WriteLine($"Value: {item.Value}, Matches Position: {item.MatchesPosition}");
            }

            //-5
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var pairs = numbersA
                   .SelectMany(a => numbersB
                      .Where(b => a < b)
                      .Select(b => new { NumberA = a, NumberB = b }))
                   .ToList();
            foreach (var pair in pairs)
            {
             Console.WriteLine($"NumberA: {pair.NumberA}, NumberB: {pair.NumberB}");
            }

            //-6
            var ordersBelow500 = CustomerList
                     .SelectMany(c => c.Orders)
                     .Where(o => o.Total < 500.00M)
                     .ToList();
            foreach (var order in ordersBelow500)
            {
             Console.WriteLine($"Order ID: {order.OrderID}, Total: {order.Total}");
            }
            #endregion

            #region 6
            //-1
            var uniqueCategories = ProductList
                    .Select(p => p.Category)
                    .Distinct()
                    .ToList();
            foreach (var category in uniqueCategories)
            {
             Console.WriteLine(category);
            }

            //-2
            var uniqueFirstLetters = ProductList
                       .Select(p => p.ProductName[0])
                       .Union(CustomerList.Select(c => c.CustomerName[0]))
                       .Distinct()
                       .ToList();
            foreach (var letter in uniqueFirstLetters)
            {
             Console.WriteLine(letter);
            }

            //-3
            var commonFirstLetters = ProductList
                   .Select(p => p.ProductName[0])
                   .Intersect(CustomerList.Select(c => c.CustomerName[0]))
                   .ToList();
            foreach (var letter in commonFirstLetters)
            {
             Console.WriteLine(letter);
            }

            //-4
            var productUniqueFirstLetters = ProductList
                    .Select(p => p.ProductName[0])
                    .Except(CustomerList.Select(c => c.CustomerName[0]))
                    .ToList();
            foreach (var letter in productUniqueFirstLetters)
            {
             Console.WriteLine(letter);
            }
            #endregion

            #region 7
            //-1
            var firstThreeOrdersFromWA = CustomerList
                    .Where(c => c.Region == "WA")
                    .SelectMany(c => c.Orders)
                    .Take(3)
                    .ToList();
            foreach (var order in firstThreeOrdersFromWA)
            {
             Console.WriteLine($"Order ID: {order.OrderID}, Order Date: {order.OrderDate}");
            }

            //-2
            var allButFirstTwoOrdersFromWA = CustomerList
                     .Where(c => c.Region == "WA")
                     .SelectMany(c => c.Orders)
                     .Skip(2)
                     .ToList();
            foreach (var order in allButFirstTwoOrdersFromWA)
            {
             Console.WriteLine($"Order ID: {order.OrderID}, Order Date: {order.OrderDate}");
            }

            //-3
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result = numbers
                         .TakeWhile((num, index) => num >= index)
                         .ToList();
            foreach (var number in result)
            {
             Console.WriteLine(number);
            }

            //-4
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var resultFromDivisibleBy3 = numbers
                      .SkipWhile(num => num % 3 != 0)
                      .ToList();
            foreach (var number in resultFromDivisibleBy3)
            {
             Console.WriteLine(number);
            }
            #endregion

            #region 8
            //-1
            string[] dictionaryWords = File.ReadAllLines("dictionary_english.txt");
            bool containsEi = dictionaryWords
                      .Any(word => word.Contains("ei"));
            Console.WriteLine($"Any word contains 'ei': {containsEi}");

            //-2
            var categoriesWithOutOfStockProducts = ProductList
                     .Where(p => p.UnitsInStock == 0)
                     .GroupBy(p => p.Category)
                     .ToList();
            foreach (var categoryGroup in categoriesWithOutOfStockProducts)
            {
                Console.WriteLine($"Category: {categoryGroup.Key}");
                foreach (var product in categoryGroup)
                {
                 Console.WriteLine($"   Product: {product.ProductName}, Units In Stock: {product.UnitsInStock}");
                }
            }

            //-3
            var categoriesWithAllProductsInStock = ProductList
                          .GroupBy(p => p.Category)
                          .Where(g => g.All(p => p.UnitsInStock > 0))
                          .ToList();

            foreach (var categoryGroup in categoriesWithAllProductsInStock)
            {
                Console.WriteLine($"Category: {categoryGroup.Key}");
                foreach (var product in categoryGroup)
                {
                Console.WriteLine($"   Product: {product.ProductName}, Units In Stock: {product.UnitsInStock}");
                }
            }
            #endregion
        }
    }
}
