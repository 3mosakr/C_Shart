using System.Collections.Generic;

namespace App5_Queue
{
    // Printing Job Example
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<PrintingJob> printingJobs = new Queue<PrintingJob>();
            printingJobs.Enqueue(new PrintingJob("document.docx", 2));
            printingJobs.Enqueue(new PrintingJob("user-stories.pdf", 5));
            printingJobs.Enqueue(new PrintingJob("report.xlsx", 3));
            printingJobs.Enqueue(new PrintingJob("payroll.report", 1));
            printingJobs.Enqueue(new PrintingJob("budget.xlsx", 4));
            printingJobs.Enqueue(new PrintingJob("algorithm.ppt", 2));


            Random rand = new Random();
            while (printingJobs.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                var job = printingJobs.Dequeue();
                Console.WriteLine($"Printing ... [{job}]");
                System.Threading.Thread.Sleep(rand.Next(1, 5) * 1000);
            }
        }
    }

    class PrintingJob
    {
        private readonly string _file;
        private readonly int _copies;

        public PrintingJob(string file, int copies)
        {
            _file = file;
            _copies = copies;
        }

        public override string ToString()
        {
            return $"{_file} x {_copies} Copies";
        }

    }


}
