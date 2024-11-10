namespace tasks_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // islam's carpet cleaning service
            int persmall = 25,perlarge=35;
            double tax = 0.06;
            int numsmall,numlarge;
            Console.Write("Enter of small carpets :");
            numsmall=int.Parse(Console.ReadLine());
            Console.Write("Enter of large carpets :");
            numlarge = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Price per small :{persmall}$");
            Console.WriteLine($"Price per large :{perlarge}$");
            Console.WriteLine("tax :6%");
            int sumsmall = persmall * numsmall;
            int sumlarge = perlarge * numlarge;
            int sum=sumsmall + sumlarge;
            Console.WriteLine($"cost :{sum}$");
            double taxprice = tax * sum;
            Console.WriteLine($"tax :{taxprice}$");
            Console.WriteLine("-----------------------------------------");
            double total=taxprice+sum;
            Console.WriteLine($"Total estimate {total}$");
            Console.WriteLine("This estimate is valid for 30 days");


        }
    }
}
