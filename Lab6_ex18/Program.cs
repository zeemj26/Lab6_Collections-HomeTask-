using System.Collections;

IList arrayList1 = new ArrayList();
arrayList1.Add(100);
arrayList1.Add(200);
//ArrayList arrayList2 = new ArrayList();
arrayList1.Add(400);
arrayList1.Add(700);
arrayList1.Remove(100);
arrayList2.InsertRange(2, arrayList1);
foreach (var item in arrayList1)
{
    Console.WriteLine(item);
}
