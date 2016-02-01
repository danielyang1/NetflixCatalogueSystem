using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    public class View
    {
        public static void printGenreTitle(Genre genre)
        {
            Console.WriteLine(genre.name);
            foreach (Title title in genre.MyTitles)
            {
                Console.WriteLine("{0}", title.Name);
            }
        }
    }
}
