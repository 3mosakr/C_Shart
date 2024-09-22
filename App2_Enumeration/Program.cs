namespace App2_Enumeration
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //var emp1 = new Employee(1, "ali");
            //var emp2 = new Employee(1, "ali");
            //Console.WriteLine(emp1 == emp2);
            //Console.WriteLine(emp1.Equals(emp2));
            //Console.WriteLine(emp1.GetHashCode() == emp2.GetHashCode());

            /* --------- Enumeration / Iterator / yeild ----------- */

            //var numbers = new FiveNumbers(2, 8, 9, 7, 1);
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            /* --------- IComparable  how to Compare two objects -------- */
            // Sort List of Ojects

            Random rand = new Random();
            var tempretures = new List<Tempreture>();

            for (int i = 0; i < 20; ++i)
            {
                tempretures.Add(new Tempreture(rand.Next(-100,100)));
            }

            tempretures.Sort();

            for (int i = 0; i < 20; ++i)
            {
                Console.WriteLine(tempretures[i]._value);
            }

        }
    }

}
