namespace Zadacha_11._22
{
    public class Bed : Furniture
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public BedSpecs BedSpecs { get; set; }

        public Bed(string name, decimal price, Material material, string manufacturer, double height, double width, BedSpecs bedSpecs)
            : base(name, price, material, manufacturer)
        {
            Height = height;
            Width = width;
            BedSpecs = bedSpecs;
        }
    }
    public enum BedSpecs
    {
        Nails, Spring, Matrak
    }
}