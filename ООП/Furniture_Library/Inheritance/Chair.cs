namespace Task.Inheritance
{
    public class Chair : Furniture
    {
        public Chair(decimal price, string name, Material material, string manufacturer) : base(price, name, material, manufacturer)
        {

        }
        public Chair(decimal price, string name, Material material, string manufacturer, double height, bool canRotate, bool hasSpring, bool hasHandResters)
            : this(price, name, material, manufacturer)
        {
            Height = height;
            CanRotate = canRotate;
            HasSpring = hasSpring;
            HasHandResters = hasHandResters;
        }
        public double Height { get; set; }
        public bool CanRotate { get; set; }
        public bool HasSpring { get; set; }
        public bool HasHandResters { get; set; }
        public int WeightSupport { get; set; }
    }
}