using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class Movie : Title
    {
        public int duration;
        public Movie(string name, int duration)
        {
            this.Name = name;
            this.duration = duration;
        }

        public override string ToString()
        {
            return Name + " : " + duration;
        }
    }
}
