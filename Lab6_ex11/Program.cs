using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> intList1 = new List<int>() { 10, 20, 30, 40 };
        bool res = intList1.TrueForAll(el => el % 2 == 0);
    }

}
