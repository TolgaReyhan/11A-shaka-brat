using Task.Enum;

namespace Task.Inheritance
{
    public class Bed : Furniture
    {
        public Bed(decimal price, string name, Material material, string manufacturer) : base(price,name,material,manufacturer)
        {

        }
        public Bed(decimal price, string name, Material material, string manufacturer, double height, double width, int userCount, BedSpecs bedSpecs) 
            : this(price,name,material,manufacturer)
        {
            Height = height;
            Width = width;
            UsersCount = userCount;
            BedSpecs= bedSpecs;
        }
        public double Height { get; set; }
        public double Width { get; set; }
        public int UsersCount { get; set; }
        public BedSpecs BedSpecs { get; set; }
    }
}