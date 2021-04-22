using System;

namespace GameRecap
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer() { Id = 1, FirstName = "GUVEN", 
                LastName = "BOYDAK", DateOfBirth = new DateTime(1993, 3, 3), 
                IdentityNumber = 12344567894 };

            Gamer gamer2 = new Gamer()
            {
                Id = 2,
                FirstName = "AYLIN",
                LastName = "BOYDAK",
                DateOfBirth = new DateTime(1992, 6, 8),
                IdentityNumber = 12344567896
            };

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);
            Console.WriteLine(gamer1.FirstName + " " + gamer1.LastName + " " + gamer1.IdentityNumber);
            Console.WriteLine();

            gamerManager.Delete(gamer1);
            Console.WriteLine();

            gamerManager.Update(gamer2);
            Console.WriteLine(gamer2.FirstName + " " + gamer2.LastName + " " + gamer2.IdentityNumber);
            Console.WriteLine();


            Game game1 = new Game() { GameId = 11, GameName = "Football Manager", };
            Game game2 = new Game() { GameId = 12, GameName = "The Last Of Us",  };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            Console.WriteLine(game1.GameId + "  " +  game1.GameName);
            Console.WriteLine();

            gameManager.Delete(game1);
            Console.WriteLine();

            gameManager.Update(game2);
            Console.WriteLine(game2.GameId + "  " + game2.GameName);

            Console.WriteLine();

            Campaing campaing1 = new Campaing() { CampaingName = "New Year", CampaingDiscount = 15 };
            Campaing campaing2 = new Campaing() { CampaingName = "Black Friday", CampaingDiscount = 35 };

            Sales sales1 = new Sales() { SalesId = 1, salerName = "Ali", Price = 25 };
            Sales sales2 = new Sales() { SalesId = 2, salerName = "Fatih", Price = 15 };


            SalesManager salesManager = new SalesManager();
            salesManager.CampaingSell(gamer1,game1,sales1,campaing1);
            salesManager.Sell(gamer1, game1, sales1);
            Console.WriteLine();

            salesManager.CampaingSell(gamer2, game2, sales2, campaing2);
            salesManager.Sell(gamer2, game2, sales2);







        }
    }
}
