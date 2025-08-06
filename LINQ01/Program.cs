﻿using System.Runtime.CompilerServices;

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
        var digits = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        var result = digits.Where( d => d.Length < Array.IndexOf(digits, d) );
        result.Print();
        #endregion

        #region Question4
        var first = ListGenerators.ProductList.FirstOrDefault(p => p.UnitsInStock == 0); first.Print();
        #endregion

        #region Question5
        var firstExp = ListGenerators.ProductList.FirstOrDefault(p => p.UnitPrice == 1000); firstExp.Print();
        #endregion

        #region Question6
        var skip = new[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        var resSkip = skip.Where(n => n>5).FirstOrDefault();

        resSkip.Print();
        #endregion
    }
}