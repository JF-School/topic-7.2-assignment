using System.Security.Cryptography.X509Certificates;

namespace _7._2_assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // count down
            Console.WriteLine("COUNT DOWN.");
            for (int countDown = 10; countDown >= 0; countDown -= 1)
            {
                Console.Write(countDown + " ");
                if (countDown == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("BLAST OFF!");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();

            // ex's and oh's
            Console.WriteLine("X AND Y");
            Console.WriteLine();
            Console.WriteLine("X\tY");
            int y;
            for (int x = -10; x <= 10; x = x+2)
            {
                y = x * x;
                Console.WriteLine(x + "\t" + y);
            }
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();

            // for loop fun challenge thingy
            int change = 10;
            Console.WriteLine("FOR LOOP FUN");
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine().ToLower().Trim();
            Console.WriteLine();
            if (userName == "aldworth")
                change = 5;
            for (int repeat = 1; repeat <= change; repeat += 1)
            {
                Console.WriteLine(repeat + ". " + userName);
            }

        }
    }
}
