internal class Program
{
    static void Main(string[] args)
    {
        // List <T> - generic
        // Liste olusturmak uzere kullanilir
        // Type - T - Yer tutucu / List <int>() / List <double>() vs seklinde yazilir
        // Tip guvenligi - "Type-Safe" 


        // Tanimlama

        //List<int> numbers = new List<int>();
        var numbers = new List<int>();

        int x = 65;
        int[] Seri = new int[] { 70, 80, 90 };

        // Ekleme
        numbers.Add(10);
        numbers.Add(15);
        numbers.Add(20);
        numbers.Add(x);
        numbers.AddRange(Seri);
        // ya da ucuncu yol olarak numbers.AddRange(new int[] {40,59,60}); yazabilirim

        // Seriyi eklemek icin birinci yol 
        // foreach ( var item in Seri)
        // { 
        // numbers.Add(item);
        // }

        // ikinci yol ise numbersin son satirinda yaziyor!

        //Araya ekleme
        numbers.Insert(3, 0);
        numbers.InsertRange(4, new int[] { 80, 90 });

        // sifir degerindeki kod bolumunu atma
        numbers.RemoveAt(3);
        numbers.RemoveAt(numbers.IndexOf(65));


        // Dolasma
        foreach (int n in numbers)
        {
            Console.Write($"{n, -5}");
        }
        Console.ReadKey();
    }
}