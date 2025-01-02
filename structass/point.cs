using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structass_
{ //2.Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
  //Write a C# program that takes two points as input from the user
  //and calculates the distance between them.
    internal struct Point
    {

		int x;
		int y;

		public int X
		{
			get; set;
		}	

		public int Y
		{
			get; set;
		}
        public double distance(int x, int y, int xx, int yy)

        {    
            double d = Math.Sqrt(Math.Pow((xx - x), 2) + Math.Pow((yy - y), 2));
			
            return d;
        }

    }
}
