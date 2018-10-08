using System;
using NUnit.Framework;
using Shapes;
// remember to reference and import your shape library

namespace Quadrilateral_Tests {
    
    
    [TestFixture]
    
    public class Tests {
        Square Sq1 { get; set; }
        Rectangle Rec1 { get; set; }
       
        Square Sq2 { get; set; }
        Rectangle Rec2 { get; set; }
       
        [SetUp]
        public void Init() {
            
            Sq1 = new Square("Blue", 4);
            Rec1 = new Rectangle("Red", 4, 3);
            
            Sq2 = new Square("Blue", 6);
            Rec2 = new Rectangle("Red", 5, 4);
        }
        
        [Test]
        public void SquareTests() {
            int area = 16;
            int perimeter = 16;
            
            Assert.AreEqual(area, Sq1.GetArea());
            Assert.AreEqual(perimeter, Sq1.GetPerimeter());
            
            area = 36;
            perimeter = 24;
            
            Assert.AreEqual(area, Sq2.GetArea());
            Assert.AreEqual(perimeter, Sq2.GetPerimeter());

        }

        [Test]
        public void RectangleTests() {
            int area = 12;
            int perimeter = 14;
            
            Assert.AreEqual(area, Rec1.GetArea());
            Assert.AreEqual(perimeter, Rec1.GetPerimeter());

            area = 20;
            perimeter = 18;
            
            Assert.AreEqual(area, Rec2.GetArea());
            Assert.AreEqual(perimeter, Rec2.GetPerimeter());

        }
        
    }
}