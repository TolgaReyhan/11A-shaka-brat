namespace Zadacha_11._22
{
    public class Chair : Furniture
    {
        public double Height { get; set; }
        public bool CanRotate { get; set; }
        public bool HasSpring { get; set; }
        public bool HasHandResters { get; set; }
        public double WeightSupport { get; set; }

        public Chair(string name, decimal price, Material material, string manufacturer, double height, bool canRotate, bool hasSpring, bool hasHandResters, double weightSupport)
            : base(name, price, material, manufacturer)
        {
            Height = height;
            CanRotate = canRotate;
            HasSpring = hasSpring;
            HasHandResters = hasHandResters;
            WeightSupport = weightSupport;
        }
    }
}