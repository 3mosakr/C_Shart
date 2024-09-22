namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            IFoo f = new Buzz();

            Action<string> action = print;
            action("ali");

            Func<int, int, int> func = add;
            Console.WriteLine(func(2,2));

            Predicate<int> predicate = isEven;
            Console.WriteLine(isEven(9));
        }

        static void print(string name) => Console.WriteLine(name);
        static int add(int n1, int n2) => n1 + n2;
        static bool isEven(int n) => n % 2 == 0;
        
    }

    interface IFoo { 
        void Foo();
    }

    class Buzz : IFoo
    {
        //public delegate T  Xyz<out T, in T2>(T2 x);
        public void Foo()
        {

        }
        public void Bar() 
        { 
        }
        
    }
    
}
