using Task.Enum;

namespace Task.Inheritance
{
    public class Desk : Furniture
    {
        public Desk(double weight, decimal price, string name, Material material, string manufacturer) : base(weight, price, name, material, manufacturer)
        {

        }
        public Desk(double weight, decimal price, string name, Material material, string manufacturer, double height, double width, Color color) 
            : this(weight, price, name, material, manufacturer)
        {
            Height = height;
            Width = width;
            Color = color;
        }

        public double Height { get; set; }
        public double Width { get; set; }
        public Color Color { get; set; }
    }
}