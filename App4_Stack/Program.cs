namespace App4_Stack
{
    // Browser History Example 
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Command> undo = new Stack<Command>();
            Stack<Command> redo = new Stack<Command>();

            string line;
            while(true)
            {
                Console.Write("URL ('exit' to quit): ");
                line = Console.ReadLine().ToLower();
                if (line == "exit")
                {
                    break;
                }
                else if (line == "back")
                {
                    if(undo.TryPop(out Command c))
                    {
                        redo.Push(c);
                    }
                    else
                    {
                        continue;
                    }
                    //if(undo.Count > 0)
                    //{
                    //    var item = undo.Pop();
                    //    redo.Push(item);
                    //}
                    //else
                    //{
                    //    continue;
                    //}
                    
                }
                else if (line == "forward")
                {
                    if (redo.TryPop(out Command c))
                    {
                        undo.Push(c);
                    }
                    else
                    {
                        continue;
                    }
                    //if (redo.Count > 0)
                    //{
                    //    var item = redo.Pop();
                    //    undo.Push(item);
                    //}
                    //else
                    //{
                    //    continue;
                    //}

                }
                else
                {
                    undo.Push(new Command(line));
                }

                // Clear the console to reuse it clearly 
                Console.Clear();

                print("Black", undo);
                print("Forward", redo);

            } // end of while
  
        }// end of main

        public static void print(string name, Stack<Command> commands)
        {
            Console.WriteLine($"{name} History");
            Console.BackgroundColor = name.ToLower() == "black" ? ConsoleColor.DarkGreen : ConsoleColor.DarkBlue;
            foreach (var u in commands)
            {
                Console.WriteLine($"\t{u}");
            }
            Console.BackgroundColor= ConsoleColor.Black;
        }

    }


    class Command
    {
        private readonly string _url;
        private readonly DateTime _createdAt;

        public Command(string url)
        {
            _url = url;
            _createdAt = DateTime.Now;
        }

        public override string ToString()
        {
            return $"[{this._createdAt.ToString("yyyy-MM-dd hh:mm")}] {this._url}";
        }

    }
}
