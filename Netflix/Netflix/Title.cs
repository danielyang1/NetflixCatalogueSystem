using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    public abstract class Title
    {
        public string Name;
        public Nullable<int> rating;

        public Title(string name, int rating)
        {
            this.Name = name;
            this.rating = rating;
        }
        public Title()
        {
            this.Name = null ;
            this.rating = null;
        }
    }
}