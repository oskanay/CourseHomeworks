using System;
using Day5_Hw5.Abstract;
using Day5_Hw5.Entities;
using Day5_Hw5.Concrete;


namespace Day5_Hw5
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game();

            game1.GameName = "Counter Strike";
            game1.GameCategory = "FPS";
            game1.GamePrice = 300;

            Game game2 = new Game();

            game2.GameName = "Age Of Empire";
            game2.GameCategory = "Strateji";
            game2.GamePrice = 220;

            Game game3 = new Game();

            game3.GameName = "League of Legends";
            game3.GameCategory = "RPG";
            game3.GamePrice = 152;

            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "Yaz Kampanyası";
            campaign1.CampaignDiscount = 15;
            campaign1.CampaignDateTime = new DateTime(2020, 6, 23);

            Campaign campaign2 = new Campaign();
            campaign1.CampaignName = "Öğrenci Kampanyası";
            campaign1.CampaignDiscount = 25;
            campaign1.CampaignDateTime = new DateTime(2018, 9, 12);

            Campaign campaign3 = new Campaign();
            campaign3.CampaignName = "Öğrenci Kampanyası";
            campaign3.CampaignDiscount = 25;
            campaign3.CampaignDateTime = new DateTime(2016, 12, 12);

            Gamer gamer1 = new Gamer();
            gamer1.FirstName = "Oskan Kemal";
            gamer1.LastName = "Aydoğdu";
            gamer1.NationalityId = "12345678910";
            gamer1.DateOfBirth = new DateTime(1995, 2, 12);

            Gamer gamer2 = new Gamer();
            gamer2.FirstName = "Engin";
            gamer2.LastName = "Demiroğ";
            gamer2.NationalityId = "12345158910";
            gamer2.DateOfBirth = new DateTime(1997, 8, 9);

            Gamer gamer3 = new Gamer();
            gamer3.FirstName = "Aslı";
            gamer3.LastName = "Gürbüz";
            gamer3.NationalityId = "12362478910";
            gamer3.DateOfBirth = new DateTime(1995, 10, 2);

            GamerManager gamerManager = new GamerManager(new VerificationManager());
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);
            gamerManager.Add(gamer3);
            gamerManager.Update(gamer3);

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Add(campaign3);

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sale(gamer1, game1, campaign1);
            gameSaleManager.Sale(gamer2, game2, campaign2);
            gameSaleManager.Sale(gamer3, game3, campaign3);

            Console.ReadLine();





        }
    }
}
