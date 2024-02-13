namespace P2Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] stores = new int[5];
            StoreSales(ref stores);
            

            Barchart(stores);
        }
        static void StoreSales(ref int[] stores)
        {

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter sales for Store {i+1}:");
                stores[i] = int.Parse(Console.ReadLine());
                stores[i] = stores[i] / 100;
            }
        }
        static void Barchart(int[] stores)
        {
            foreach (int i in stores)
            {
               for (int j = 0; j < i; j++)
               {
                    Console.Write("*");
               }
                Console.WriteLine(" ");
            }
        }
    }
}