using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    public class Genre : IEnumerable
    {
        public string name;
        public List<Title> MyTitles = new List<Title>();
        public Genre()
        {
            this.name = name;
        }
        public static Genre operator +(Genre genre1, Genre genre2)
        {
            Genre newGenre = new Genre();
            newGenre.MyTitles.AddRange(genre1.MyTitles); //union will exclude duplicates.. Concat INCLUDES dups
            newGenre.MyTitles.AddRange(genre2.MyTitles);
            return newGenre;
        }
        public static Genre operator +(Genre genre1, Title title)
        {
            Genre newGenre = new Genre();
            newGenre.MyTitles.AddRange(genre1.MyTitles);
            newGenre.MyTitles.Add(title);
            return newGenre;
        }
        public IEnumerator GetEnumerator()
        {
            foreach (Title title in MyTitles)
            {
                yield return name;
            }
        }
    } 
}
