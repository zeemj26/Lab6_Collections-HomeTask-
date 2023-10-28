using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        IList<int> intList1 = new List<int>() { 10, 20, 30, 40 };
        for(int i=0; i<intList1.Count; i++) { Console.WriteLine(intList1[i]); }
    }
}
