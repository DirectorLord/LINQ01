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
        #region Question1
        var outOfStock = ListGenerators.ProductList.Where(p => p.UnitsInStock == 0);

        outOfStock.Print();
        #endregion

        #region Question2
        var priceProducts = ListGenerators.ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);

        priceProducts.Print();
        #endregion

        #region Question3

        #endregion

        #region Question4

        #endregion

        #region Question5

        #endregion

        #region Question6

        #endregion
    }
}