using System.Collections;
using System.Collections.Generic;

namespace C42_G02_LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region V1
            //var Result=  ProductList.Where(P => P.UnitsInStock == 0);

            //  Result=from P in ProductList
            //         where P.UnitsInStock == 0
            //         select P;

            //var Result = ProductList.Where(P => P.Category == "Meat/Poultry"&&P.UnitsInStock>0);

            //var Result = from P in ProductList
            //         where P.UnitsInStock > 0 && P.Category == "Meat/Poultry"
            //         select P;

            //var Result = ProductList.Where((P,I) => P.UnitsInStock == 0&&I <20);
            //var Result = ProductList.Where((P, I) => P.UnitsInStock > 0 && I < 5);

            //ArrayList list = new ArrayList() {"mo",1,"ali",2,"ahmed",1.5,23,"M" };

            //var Result= List.OfType<int>();
            //var Result = List.OfType<string>();
            //var Result = List.OfType<double>();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region V2
            //var Result = ProductList.Select(P => P.ProductName);
            //var Result = CustomersList.Select(C => C.CustomerName);
            //var Result ProductList.Select(P => {  return new {P.ProductId,P.ProductName}; });
            //var Result = from P in ProductList
            //         select P;
            //var Result = from P in ProductList
            //             select P.ProductName;
            //var Result = from P in ProductList
            //             select new
            //             {
            //                 P.ProductId,
            //                 P.ProductName
            //             };

            //var Result = CustomersList.Select(C => C.Orders);
            //var Result = CustomersList.SelectMany(C => C.Orders);

            //var Result = from C in CustomersList
            //             from O in C.Orders
            //             select O;

            //var Result = ProductList.Where(P => P.UnitsInStock > 0).Select(P =>
            //new
            //{
            //    P.ProductId,
            //    P.ProductName,
            //    NewPrice = P.UnitPrice- P.UnitPrice*0.1M
            //});

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region V3
            //var Result = ProductList.OrderBy(P => P.UnitPrice);
            //var Result = ProductList.OrderByDescending(P => P.UnitPrice);
            //var Result = from P in ProductList
            //       orderby P.UnitPrice
            //        select P;
            //var Result = ProductList.Select(P => new { P.ProductName, P.UnitsInStock, P.UnitPric }).orderby(P.UnitsInStock);
            //var Result = from P in ProductList
            //             orderby P.UnitsInStock, P.UnitPric ascending
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.UnitsInStock,
            //                 P.UnitPric
            //             };
           //var Result= ProductList.Reverse<Product>();
           // foreach (var item in Result)
           // {
           //     Console.WriteLine(item);
           // }
            #endregion

            #region
            #endregion
        }
    }
}
