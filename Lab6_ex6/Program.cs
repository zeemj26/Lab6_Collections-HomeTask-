using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        IList<int> intList1 = new List<int>() { 10, 20, 30, 40 };
        Console.WriteLine("Total element {0} : ",intList1.Count);
    }
}
