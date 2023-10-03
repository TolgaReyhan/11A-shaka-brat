using System.Globalization;

namespace ContstructorsDemo
{
    internal class ContstructorsDemo
    {
        static void Main(string[] args)
        {
            var man = new Manufacturer();
            man.Name = "Georgi";
            var man2 = new Manufacturer("Atanas", "+359-953-67-23");
            var man3 = new Manufacturer("Hristiqn", "+359888753", "vuzdoh,com", "hristiqn@abv.bg");
            var manufactures = new List<Manufacturer>()
            {
                new Manufacturer()
                {
                    Id = 1,
                    Name = "Lex",
                    Telephone = "0883368643",
                    Email = "lex@yahoo.com",
                    WebSiteURL = "www.lex-company.com"
                },
                new Manufacturer()
                {
                    Id = 2,
                    Name = "Krasi",
                    Telephone = "0889973642",
                    Email = "krasi-batinka@yahoo.com",
                    WebSiteURL = "www.krasi-grass.com"
                },
            };
            manufactures.Add(new Manufacturer("Coma", "+359885938360", "doktorkostov-etuka.com", "rigidididimarko@abv.bg"));
            manufactures.Add(new Manufacturer("Adibas", "+359999999999", "adinabas.com", "adidasbatka@abv.bg"));
            manufactures.Add(new Manufacturer("PRIME", "+35977777777", "getyourprime.com", "getinyourprime@gmail.com"));
            var products = new List<Product>()
            {
                new Product()
                {
                Name = "Prah za prane LEX",
                Description = "Hitriqt nachin za prane LEX, ReX i t.n....",
                PriceBGN = 12.43m,
                WeightKgs = 2,
                ProductType = ProductType.CleaningSupplies,
                Manufacturer = manufactures[0],
                ExpirationDate = DateTime.ParseExact("02/10/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture)
            },
               new Product()
            {
                Name = "Gornicka Adibas",
                Description = "Vzemi si Adibas za da stanesh batka",
                PriceBGN = 99.99m,
                WeightKgs = 0.300d,
                Manufacturer = manufactures[3],
                ExpirationDate = DateTime.ParseExact("00/00/0000", "dd/MM/yyyy", CultureInfo.InvariantCulture)
            },
                new Product()
            {
                Name = "Teniska Coma",
                Description = "S tazi teniska avtomatichno stavash shefa ne relefa",
                PriceBGN = 29.99m,
                WeightKgs = 0.200d,
                Manufacturer = manufactures[2],
                ExpirationDate = DateTime.ParseExact("00/00/0000", "dd/MM/yyyy", CultureInfo.InvariantCulture)
            },
                new Product("Napitka Prime", "Piesh ot nashata napitka i za 5 sekundi vlizash v nay dobrata si forma",5.99m,0.500d,ProductType.BeverageNonAlcohol,"28/09/2025",manufactures[4]),
                new Product("Napitka Prime", "Piesh ot nashata napitka i za 5 sekundi vlizash v nay dobrata si forma",5.99m,0.500d,ProductType.BeverageNonAlcohol,"28/09/2025",manufactures[4]),
                new Product("Napitka Prime", "Piesh ot nashata napitka i za 5 sekundi vlizash v nay dobrata si forma",5.99m,0.500d,ProductType.BeverageNonAlcohol,"28/09/2025",manufactures[4]),
                new Product("Napitka Prime", "Piesh ot nashata napitka i za 5 sekundi vlizash v nay dobrata si forma",5.99m,0.500d,ProductType.BeverageNonAlcohol,"28/09/2025",manufactures[4]),
                new Product("Napitka Prime", "Piesh ot nashata napitka i za 5 sekundi vlizash v nay dobrata si forma",5.99m,0.500d,ProductType.BeverageNonAlcohol,"28/09/2025",manufactures[4]),

        };

        }
    }
    public class Product
    {
        private string name;
        public Product()
        {
        }

        public Product(string name, string description, decimal priceBGN, double weightKgs, ProductType productType, string expirationDate, Manufacturer manufacturer)
        {
            Name = name;
            Description = description;
            PriceBGN = priceBGN;
            WeightKgs = weightKgs;
            ProductType = productType;
            ExpirationDate = DateTime.ParseExact(expirationDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Manufacturer = manufacturer;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description { get; set; }
        public decimal PriceBGN { get; set; }
        public double WeightKgs { get; set; }
        public ProductType ProductType { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
    public enum ProductType
    {
        Food, BeverageAlcohol, BeverageNonAlcohol, CleaningSupplies, Clothing,
    }
    public class Manufacturer
    {
        private string telephone;

        public int Id { get; set; }
        public string Name { get; set; } = "Asen";
        public string WebSiteURL { get; set; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Email { get; set; }

        public Manufacturer()
        {
            Name = "Genadi";
        }
        public Manufacturer(string name, string phoneNumber)
        {
            Name = name;
            Telephone = phoneNumber;
        }

        public Manufacturer(string name, string webSiteURL, string telephone, string email)
        {
            Name = name;
            WebSiteURL = webSiteURL;
            this.telephone = telephone;
            Email = email;
        }
    }
}