namespace StaticConstructorDestructorStackAndHeap
{
    public static class VetClinic
    {
        public static string Name { get; set; }
        static VetClinic()
        {
            Name = "Super Klinika Shumen";
            Console.WriteLine("Pusna se statichne konsturktor");
        }
    }
}