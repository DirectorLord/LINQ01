using System.Runtime.CompilerServices;

namespace LINQ01;

internal class Program
{   
    public static void Main()
    //made the printing method in the Methods file so i can print it and to make the data to be shown
    //this is the result of the data without the print
    //System.Linq.Enumerable+ListWhereIterator`1[LINQ01.Product]
    //what is this??????
    {
        var result = ListGenerators.ProductList.Where(p => p.UnitsInStock == 0);

        Console.WriteLine(result);
    }
}