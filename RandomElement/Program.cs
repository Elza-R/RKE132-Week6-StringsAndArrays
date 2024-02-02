string[] snacks = { "suchi", "pizza", "burger", "chicken wings", "Asian takeaway" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length); //5 - 1

Console.WriteLine($"Tonight we are going to eat {snacks[randomIndex]}.");
