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

            //Result = from P in ProductList
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
        }
    }
}
