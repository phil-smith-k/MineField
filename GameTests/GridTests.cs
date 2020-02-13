using System;
using GameClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameTests
{
    [TestClass]
    public class GridTests
    {
        [TestMethod]
        public void GenerateGrid_FirstLineTest()
        {
            Grid grid = new Grid();
            string result = grid.GenerateGrid(3);
            Console.WriteLine(result);
        }
        [TestMethod]
        public void GenerateGrid_WholeGridTest()
        {
            Grid grid = new Grid();
            string result = grid.GenerateGrid(3);
            Console.WriteLine(result);
        }
    }
}
