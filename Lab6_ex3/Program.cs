﻿using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        IList<int> intList = new List<int> { 10, 20, 30 };

        foreach (var el in intList)
        {
            Console.WriteLine(el);
        }
    }
}
