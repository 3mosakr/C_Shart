using System.Text.Json;

namespace Serialization_Json
{
    internal class Program
    {
        private readonly static HttpClient httpClient = new HttpClient();
        static async Task Main(string[] args)
        {
            var todoesJsonContent = await httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/todos");

            var todoes = JsonSerializer.Deserialize<List<Todo>>(todoesJsonContent, 
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true});

            foreach (var item in todoes)
            {
                if(item.Completed == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine(item);
            }
            Console.ForegroundColor =ConsoleColor.White;
        }
    }

    public class Todo
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }

        public override string ToString()
        {
            return $"[{Id} - User id = {UserId}, {Title}]";
        }
    }

}
