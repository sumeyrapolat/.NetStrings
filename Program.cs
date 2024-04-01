// See https://aka.ms/new-console-template for more information


//Konsoldan girilen n tane sayıyı diziye ekleyip ortalamasını yazdıran algortima:

Console.Write("Lütfen dizinin eleman sayısını giriniz : ");

int stringLength = int.Parse(Console.ReadLine());
int[] numberString = new int[stringLength];

for (int i = 0; i < stringLength; i++)
{
    Console.Write("Lütfen dizinin {0}. elemanını giriniz : ", i+1);
    numberString[i] = int.Parse(Console.ReadLine());

}

int sum = 0;
foreach (var number in numberString)
    sum += number;

Console.WriteLine("Ortalama: " + sum/stringLength);
