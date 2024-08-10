
int[] intArray = new int[10]; // array oluşturuldu

for (int i = 0; i < intArray.Length; i++) 
{
    intArray[i] = i; // 0 dan başlayarak sayılar arrayin içine atıldı
}

foreach (var item in intArray)
{
    System.Console.WriteLine(item); // array ekrana yazıldı
}
System.Console.Write("Lütfen 11. elemanı giriniz: ");

string stringInput =Console.ReadLine();
int intInput=0;

int.TryParse(stringInput, out intInput); // string alınan veri int e çevrildi

Array.Resize(ref intArray, intArray.Length+1); // arrayin eleman sayısı +1 eklendi

intArray[10]=intInput;
foreach (var item in intArray)
{
    System.Console.WriteLine(item);
}

Array.Sort(intArray); // küçükten büyüğe sıralandı
Array.Reverse(intArray,0,intArray.Length); // dizi ters çevirilerek büyükten küçüğe sıralandı
System.Console.WriteLine("----------------Yeni dizi-------------");
foreach (var item in intArray)
{
    System.Console.WriteLine(item);
}
