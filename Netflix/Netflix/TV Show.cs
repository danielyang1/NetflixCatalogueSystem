using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    public class TV_Show : Title
    {
        public List<Episode> ListEpisodes = new List<Episode>();

        public TV_Show(string Name)
        {
            this.Name = Name;
        }
        public new int rating
        {
            get
            {
                int aveRating = 0;
                foreach (Episode rating in ListEpisodes)
                {
                    aveRating += rating.rating;
                }
                return aveRating / ListEpisodes.Count;
            }
            //set
            //{
            //    delete before sending to GitHub
            //}
        }
        public override string ToString()
        {
            return Name + " : " + ListEpisodes.Count;
        }
    }
}
