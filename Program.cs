int[] intArray = new int[10];

for (int i = 0; i < intArray.Length; i++)
{
    intArray[i] = i;
}

foreach (var item in intArray)
{
    System.Console.WriteLine(item);
}
System.Console.Write("Lütfen 11. elemanı giriniz: ");

string stringInput =Console.ReadLine();
int intInput=0;

int.TryParse(stringInput, out intInput);

Array.Resize(ref intArray, intArray.Length+1);

intArray[10]=intInput;
foreach (var item in intArray)
{
    System.Console.WriteLine(item);
}

Array.Sort(intArray);
Array.Reverse(intArray,0,intArray.Length);
System.Console.WriteLine("----------------Yeni dizi-------------");
foreach (var item in intArray)
{
    System.Console.WriteLine(item);
}