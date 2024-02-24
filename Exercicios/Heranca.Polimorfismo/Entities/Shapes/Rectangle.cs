using System.Drawing;

namespace Heranca.Polimorfismo.Entities.Shapes
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color)
            : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return 0;
        }
    }
}
