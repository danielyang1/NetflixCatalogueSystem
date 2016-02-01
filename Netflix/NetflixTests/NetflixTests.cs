using Microsoft.VisualStudio.TestTools.UnitTesting;
using Netflix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Tests
{
    [TestClass()]
    public class GenreTests
    {
        [TestMethod()]
        public void Test1()
        {
            Movie superman = new Movie("Superman", 119);
            Assert.AreEqual(superman.duration, 119);
        }
        [TestMethod()]
        public void Test2()
        {
            Movie superman = new Movie("Superman", 119);
            Assert.AreEqual(superman.Name, "Superman");
        }
        [TestMethod()]
        public void Test3()
        {
            TV_Show himym = new TV_Show("How I Met Your Mother");
            Episode one = new Episode(5);
            Episode two = new Episode(4);
            himym.ListEpisodes.Add(one);
            himym.ListEpisodes.Add(two);
            Assert.AreEqual(one.rating, 5);
        }
        [TestMethod()]
        public void Test4()
        {
            TV_Show himym = new TV_Show("How I Met Your Mother");
            Episode one = new Episode(5);
            Episode two = new Episode(3);
            himym.ListEpisodes.Add(one);
            himym.ListEpisodes.Add(two);
            Assert.AreEqual(himym.Name, "How I Met Your Mother");
        }
        [TestMethod()]
        public void Test5()
        {
            TV_Show himym = new TV_Show("How I Met Your Mother");
            Episode one = new Episode(5);
            Episode two = new Episode(3);
            himym.ListEpisodes.Add(one);
            himym.ListEpisodes.Add(two);
            Assert.AreEqual(two.rating, 3);
        }
        [TestMethod()]
        public void Test6()
        {
            Movie nemo = new Movie("Finding Nemo", 89);
            nemo.Name = "Finding Nemo";
            nemo.rating = 4;
            Assert.IsNotNull(nemo.rating);
        }
        [TestMethod()]
        public void Test7()
        {
            Movie nemo = new Movie("Finding Nemo", 89);
            nemo.Name = "Finding Nemo";
            Assert.IsNull(nemo.rating);
        }
    }
}