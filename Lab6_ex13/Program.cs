using System.Collections;

namespace Lab6_ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(1);
            arrayList1.Add(2);
            arrayList1.Add("three");
            IList arrayList2 = new ArrayList()
            {
                100,200
            };
            arrayList1.AddRange(arrayList2);
        }
    }
}