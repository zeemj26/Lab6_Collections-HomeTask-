using System.Collections;

ArrayList arrayList1 = new ArrayList()
{1,
2,
"Three"
};
arrayList1.Insert(1, "Zaha");
arrayList1.Insert(2, 100);
foreach (var val in arrayList1)
{
    Console.WriteLine(val);
}
