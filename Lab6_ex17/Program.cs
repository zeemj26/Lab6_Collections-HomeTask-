using System.Collections;

IList arrayList1 = new ArrayList();
arrayList1.Add(100);
arrayList1.Add(200);
ArrayList arrayList2 = new ArrayList();
arrayList2.Add(400);
arrayList2.Add(700);

arrayList2.InsertRange(2, arrayList1);
foreach (var item in arrayList2)
{
    Console.WriteLine(item);
}
