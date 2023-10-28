using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        IList<int> intList1 = new List<int>() { 10, 20, 30, 40 };
        intList1.Insert(1, 11);
        foreach (int el in intList1) { Console.WriteLine(el); }

    }

}