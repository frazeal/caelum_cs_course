using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Simulador
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> actors = new List<string>()
            {
                "Mark Hamill",
                "Harrison Ford",
                "Carrie Fisher"
            };

            // Your code here.
            var file = new FileStream(@".\Movies.txt", FileMode.Create);
            var writer = new StreamWriter(file);

            foreach (var actor in actors)
            {
                writer.WriteLine(actor);
            }

            writer.Close();

            string str = "[message details in here][another message here]/n/n[anothermessage here]";
            string[] result = Regex.Matches(str, @"\[.*?\]").Cast<Match>().Select(m => m.Value).ToArray();

            foreach (var r in result)
            {
                Console.WriteLine(r.ToString());
            }

            List<string> actors2 = new List<string>()
        {
            "Mark Hamill",
            "Harrison Ford",
            "Carrie Fisher"
        };

            // Your code here.
            using (var file2 = new FileStream(@".\Actors.txt", FileMode.Create))
            using (var writer2 = new StreamWriter(file2))
            {
                foreach (string actor in actors2)
                {
                    writer2.WriteLine(actor);
                    }
                }

            Console.ReadKey();

            Directory.CreateDirectory(@".\sub-dir1");
            Directory.CreateDirectory(@".\sub-dir2");
            Directory.CreateDirectory(@".\sub-dir3");

            // Your code here
            DirectoryInfo directory = new DirectoryInfo(@".\");
            var children = directory.GetDirectories();

            foreach (var child in children)
            {
                Console.WriteLine(child.Name);
            }

            Console.ReadKey();
        }
    }
}
