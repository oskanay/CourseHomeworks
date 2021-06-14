using System;
using System.Collections.Generic;
using System.Text;
using Day5_Hw5.Abstract;
using Day5_Hw5.Entities;

namespace Day5_Hw5.Concrete
{
    class GameSaleManager : ISaleServer
    {
        
        public void Sale(Gamer gamer, Game game, Campaign campaign)
        {
            double newPrice = game.GamePrice - (game.GamePrice * (campaign.CampaignDiscount / 100));
            Console.WriteLine(game.GameName + " isimli oyun " + gamer.FirstName + " " + gamer.LastName + " isimli kişiye satıldı. ");
            Console.WriteLine(game.GameName + " isimli oyunun indirimli fiyatı =" + game.GamePrice * (campaign.CampaignDiscount / 100) + "TL");
            Console.WriteLine(game.GameName + " isimli oyuna uygulanan indirim fiyatı = " + newPrice + "TL");
        }
    }
}
