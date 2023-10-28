using System.Collections;

IList arrayList1 = new ArrayList();
arrayList1.Add(100);
arrayList1.Add(200);
arrayList1.Add(400);
arrayList1.Add(700);

Console.WriteLine("Original order : ");
arrayList1.RemoveRange(100, 250);

foreach (var item in arrayList1)
{
    Console.WriteLine(item);
}
arrayList1.Reverse();
Console.WriteLine("Reverse : ");
foreach (var item in arrayList1)
{
    Console.WriteLine(item);
}
arrayList1.Sort();
Console.WriteLine("Ascending order : ");
foreach (var item in arrayList1)
{
    Console.WriteLine(item);
}


