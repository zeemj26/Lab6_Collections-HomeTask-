using System;
using System.Collections.Generic;

class Program
{
    private static object intList;

    static bool isPositiveInt(int i)
    {
        return i > 0;
    }
    static void Main(string[] args)
    {
        List<int> intlist = new List<int>() { 10, 20, 30, 40 };
        bool res = intlist.TrueForAll(isPositiveInt);
    }

}
