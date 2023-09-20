namespace ZadachaZaPregovor
{
    internal class ZadachaZaPregovor
    {
        static void Main(string[] args)
        {
            //Zadacha1();
            //Zadacha2();
            //Zadacha3();
            //Zadacha4();
            //Zadacha5();
            Zadacha6();
        }

        private static void Zadacha1()
        {
            int rentOfHall = int.Parse(Console.ReadLine());
            decimal statuesValue = rentOfHall * (decimal)(1 - 0.3);
            decimal ceteringValue = statuesValue * 0.85m;
            decimal soundValue = ceteringValue / 2;
            decimal totalCost = rentOfHall + statuesValue + ceteringValue + soundValue;
            Console.WriteLine($"Cost = {totalCost:F2}");
        }

        private static void Zadacha2()
        {
            decimal budgetForFilm = decimal.Parse(Console.ReadLine());
            int statisti = int.Parse(Console.ReadLine());
            decimal valueForOutfit = decimal.Parse(Console.ReadLine());
            decimal valueOfDecor = budgetForFilm * 0.1m;
            // decimal clothesPrice = statisti * valueForOutfit;
            if (statisti >= 150)
            {
                valueForOutfit = statisti * valueForOutfit * 0.9m;
            }
            decimal finalValue = valueOfDecor + valueForOutfit;
            decimal moneyLeft = budgetForFilm - finalValue;
            decimal moneyNeeded = finalValue - budgetForFilm;
            if (budgetForFilm < finalValue)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:F2} leva more");
            }
            else if (budgetForFilm >= finalValue)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left");
            }
        }

        private static void Zadacha3()
        {
            Console.Write("Име на филма:");
            string movieName = Console.ReadLine();
            Console.Write("Вид на залата:");
            string hallType = Console.ReadLine();
            Console.Write("Брой продадени билети:");
            int ticketNumber = int.Parse(Console.ReadLine());

            decimal eranings = 0;
            decimal ticketPrice = 0;

            if (movieName == "A Star Is Born")
            {
                if (hallType == "normal") ticketPrice = 7.50m;
                else if (hallType == "luxury") ticketPrice = 10.50m;
                else if (hallType == "ultra luxury") ticketPrice = 13.50m;
            }
            else if (movieName == "Bohemian Rhapsody")
            {
                if (hallType == "normal") ticketPrice = 7.35m;
                else if (hallType == "luxury") ticketPrice = 9.45m;
                else if (hallType == "ultra luxury") ticketPrice = 12.75m;
            }
            else if (movieName == "Green Book")
            {
                if (hallType == "normal") ticketPrice = 8.15m;
                else if (hallType == "luxury") ticketPrice = 10.25m;
                else if (hallType == "ultra luxury") ticketPrice = 13.25m;
            }
            else if (movieName == "The Favourite")
            {
                if (hallType == "normal") ticketPrice = 8.75m;
                else if (hallType == "luxury") ticketPrice = 10.25m;
                else if (hallType == "ultra luxury") ticketPrice = 13.95m;
            }

            decimal earning = ticketNumber * ticketPrice;
            Console.WriteLine($"{movieName} -> {earning} lv.");
        }
        
        private static void Zadacha4()
        {
            int voucher = int.Parse(Console.ReadLine());

            int price = 0;
            int ticketPcs = 0;
            int otherProductPcs = 0;

            string product = Console.ReadLine();

            while (product != "End")
            {
                if (product.Length > 8)
                {
                    price = product[0] + product[1];

                    if (voucher >= price)
                    {
                        voucher -= price;
                    }
                    else
                    {
                        break;
                    }

                    ticketPcs++;
                }
                else
                {
                    price = product[0];

                    if (voucher >= price)
                    {
                        voucher -= price;
                    }
                    else
                    {
                        break;
                    }

                    otherProductPcs++;
                }

                product = Console.ReadLine();
            }

            Console.WriteLine(ticketPcs);
            Console.WriteLine(otherProductPcs);
        }

        private static void Zadacha5()
        {
            int movieCount = int.Parse(Console.ReadLine());

            string nameMovie = "";
            double ratingMovie = 0;

            double minRating = double.MaxValue;
            string movieMaxRating = "";
            double maxRating = double.MinValue;
            string movieMinRating = "";
            double averageRating = 0;
            for (int i = 0; i < movieCount; i++)
            {
                nameMovie = Console.ReadLine();
                ratingMovie = double.Parse(Console.ReadLine());
                if (ratingMovie > maxRating)
                {
                    maxRating = ratingMovie;
                    movieMaxRating = nameMovie;
                }
                if (ratingMovie < minRating)
                {
                    minRating = ratingMovie;
                    movieMinRating = nameMovie;
                }
                averageRating += ratingMovie;
            }
            Console.WriteLine($"{movieMaxRating} is with highest rating: {maxRating:f1}");
            Console.WriteLine($"{movieMinRating} is with lowest rating: {minRating:f1}");
            Console.WriteLine($"Average rating: {averageRating / movieCount:f1}");
        }

        private static void Zadacha6()
        {
            string movie = Console.ReadLine();
            byte numStudent = 0;
            byte numStandard = 0;
            byte numKid = 0;
            while (movie != "Finish")
            {
                byte seats = byte.Parse(Console.ReadLine());
                byte movieTickets = 0;
                for (int i = 0; i < seats; i++)
                {
                    string seatType = Console.ReadLine();
                    if (seatType == "End")
                    {
                        break;
                    }
                    else if (seatType == "student")
                    {
                        numStudent++;
                    }
                    else if (seatType == "standard")
                    {
                        numStandard++;
                    }
                    else if (seatType == "kid")
                    {
                        numKid++;
                    }
                    movieTickets++;
                }
                Console.WriteLine($"{movie} - {(float)movieTickets / seats * 100:f2}% full.");
                movie = Console.ReadLine();
            }
            int totalTickets = numStudent + numStandard + numKid;
            string output = string.Format($"Total tickets: {totalTickets}\n" +
                $"{(float)numStudent / totalTickets * 100f:f2}% student tickets.\n" +
                $"{(float)numStandard / totalTickets * 100f:f2}% standard tickets.\n" +
                $"{(float)numKid / totalTickets * 100f:f2}% kids tickets.");
            Console.WriteLine(output);
        }
    }
}