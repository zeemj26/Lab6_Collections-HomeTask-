using System.Collections;

IList arrayList1 = new ArrayList();
arrayList1.Add(100);
arrayList1.Add(200);
//ArrayList arrayList2 = new ArrayList();
arrayList1.Add(400);
arrayList1.Add(700);
arrayList1.RemoveRange(100,250);

foreach (var item in arrayList1)
{
    Console.WriteLine(item);
}
