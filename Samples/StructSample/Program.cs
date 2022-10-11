using System;

namespace StructSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.shortSide = 3;
            rectangle.longSide = 4;

            Console.WriteLine("The area of the rectangle is: {0}", rectangle.CalculateAreOfRectangle());

            //Rectangle_Struct rectangle_Struct = new Rectangle_Struct();
            Rectangle_Struct rectangle_Struct;
            rectangle_Struct.shortSide = 3;
            rectangle_Struct.longSide = 4;

            Console.WriteLine("The area of the rectangle is: {0}", rectangle_Struct.CalculateAreOfRectangle());
        }
    }

    class Rectangle
    {
        public int shortSide;
        public int longSide;

        public long CalculateAreOfRectangle()
        {
            return this.shortSide * this.longSide;
        }
    }

    struct Rectangle_Struct
    {
        public int shortSide;
        public int longSide;

        public long CalculateAreOfRectangle()
        {
            return this.shortSide * this.longSide;
        }
    }
}
