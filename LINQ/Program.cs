using System.Collections.Generic;
using System.Threading.Channels;
using LINQ;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string> {"Dragons Dogma 2", "Red Dead Redemption 2", "Elden Ring", "Stardew Valley"};
            var counter = 0;
            videoGames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine($"{counter+=1}. {x}"));



        }
    }
}
