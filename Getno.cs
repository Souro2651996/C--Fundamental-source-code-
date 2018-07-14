using System;


namespace Primenum
{
    class Getno
    {
        public void show()
        {
            try
            {
                int n, i=2;
                Console.Write("enter the number");
                n = Convert.ToInt32(Console.ReadLine());
                while (i<n)
                {
                    
                
                
                    if (n % i == 0)
                    {
                        Console.Write("not prime");
                        break;
                    }

                    i++;
                    

                }

                if (i == n)
                {
                    Console.Write("prime");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            Console.ReadKey();
        }
    }
}
