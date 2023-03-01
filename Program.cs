namespace Traffic_jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int CarToPass=int.Parse(Console.ReadLine());
            int carCounter = 0;
            Queue<string> Cars= new Queue<string>();
            
            while (true)
            {
                string cars = Console.ReadLine();
                if (cars=="end")
                {
                    break;
                }

                if (cars=="green")
                {
                    
                        for (int i = 0; i < CarToPass&&Cars.Count>0; i++)
                        {
                            Console.WriteLine($"{Cars.Dequeue()} passed!") ;
                            carCounter++;
                        }

                    continue;
                    
                }
                Cars.Enqueue(cars);
            }

            Console.WriteLine($"{carCounter} cars passed the crossroads.");

        }
    }
}