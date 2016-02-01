using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class Program 
    {
        static void Main(string[] args)
        {
            Movie scottP = new Movie("Scott Pilgrim vs the World", 119);
            Movie superman = new Movie("Superman", 110);
            Movie IT = new Movie("It", 98);
            Movie nemo = new Movie("Finding Nemo", 89);

            scottP.Name = "Scott Pilgrim vs the World";
            IT.Name = "IT";
            nemo.Name = "Finding Nemo";
            superman.Name = "Superman";

            scottP.rating = 5;
            superman.rating = 4;
            IT.rating = 3;
            nemo.rating = 4;

            Genre comedy = new Genre();
            Genre scary = new Genre();
            Genre funny = new Genre();
            comedy.name = "comedy";

            comedy.MyTitles.Add(scottP);
            comedy.MyTitles.Add(superman);
            scary.MyTitles.Add(IT);
            scary.MyTitles.Add(nemo);

            funny = (comedy+scary);

            Console.WriteLine(comedy.MyTitles[0]);
            Console.WriteLine(comedy.MyTitles[1]);
            Console.WriteLine("---");
            Console.WriteLine(scary.MyTitles[0]);
            Console.WriteLine(scary.MyTitles[1]);
            Console.WriteLine("---");
            Console.WriteLine(funny.MyTitles[0]);
            Console.WriteLine(funny.MyTitles[1]);
            Console.WriteLine(funny.MyTitles[2]);
            Console.WriteLine(funny.MyTitles[3]);
            Console.WriteLine("---");

            View.printGenreTitle(comedy);

            TV_Show himym = new TV_Show("How I Met Your Mother");
            Episode one = new Episode(5);
            Episode two = new Episode(3);
            himym.ListEpisodes.Add(one);
            himym.ListEpisodes.Add(two);
            Console.WriteLine("Name of TV Show {0}", himym);
            Console.WriteLine("Rating {0} ", himym.ListEpisodes[0].rating);
            Console.WriteLine("Rating {0} ", himym.ListEpisodes[1].rating);
            Console.WriteLine("Average Rating "+himym.rating);

            Console.ReadKey();
        }
    }
}
