using System;
using System.Collections.Generic;

namespace Shapes
{
    public abstract class Shape
    
    {   
        public string Colour { get; set; } 
        public abstract int GetArea();
        
    }
    

    
    public abstract class Quadrilaterial : Shape
    {
        public int S1 { get; set; }
        public int S2 { get; set; }
        public int S3 { get; set; }
        public int S4 { get; set; }
        

        public abstract int GetPerimeter();
        public abstract void GetInfo();
    }
    
    public abstract class Triangle : Shape
    {
        public string Colour { get; set; }
        public int s1 { get; set; }
        public int s2 { get; set; }
        public int s3 { get; set; }

        public abstract int GetPerimeter();

    }

    public class RightAngleTriangle : Triangle
    {
        
        public RightAngleTriangle(string colour, int s1, int s2)
        {
            Colour = colour;
            this.s1 = s1;
            this.s2 = s2;
        }

        public string Colour { get; set; }
        public int s1 { get; set; }
        public int s2 { get; set; }
        
        public override int GetArea()
        {
            double Half = 0.5;
            s1 = double.Parse(s1);
            return  s1 * Half * 2;
        }

        public override int GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }

    public class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(string colour, int s1)
        {
            Colour = colour;
            this.s1 = s1;
        }

        public string Colour { get; set; }
        public int s1 { get; set; }
        
        public override int GetArea()
        {
            throw new NotImplementedException();
        }

        public override int GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }


    public class Rectangle : Quadrilaterial
    {
        public Rectangle(string colour, int width, int height)
        {
            Colour = colour;
            Width = width;
            Height = height;
        }

        public string Colour { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

 
        public override int GetArea()
        {
            return Width * Height;
        }

        public override void GetInfo()
        {
            Console.WriteLine("Colour: " + Colour + Environment.NewLine +
                              " Width: " + Width + Environment.NewLine +
                              " Height: " + Height + Environment.NewLine);
            
            Console.WriteLine(GetArea());
        }


        public override int GetPerimeter()
        {
            S1 = Height;
            S2 = Width;
            S3 = Height;
            S4 = Width;
            return S1 + S2 + S3 + S4;
        }
    }
    
    
    
    public class Square : Quadrilaterial
    {
        public Square(string colour, int size)
        {
            Colour = colour;
            Size = size;
        }

        public string Colour { get; set; }
        public int Size { get; set; }

        public override int GetArea()
        {
            return Size * Size;
        }
        
        public override void GetInfo()
        {
            Console.WriteLine("Colour: " + Colour + Environment.NewLine +
                              " Size: " + Size + Environment.NewLine);
            
            Console.WriteLine(GetArea());
        }
        
        public override int GetPerimeter()
        {
            S1 = Size;
            S2 = S1;
            S3 = S2;
            S4 = S3;
            return S1 + S2 + S3 + S4;
        }

    }

}
