using System;
using System.Collections.Generic;
using System.Text;
using Day5_Hw5.Entities;
using Day5_Hw5.Abstract;

namespace Day5_Hw5.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine
                (campaign.CampaignName +  " isimli kampanya "  +  campaign.CampaignDateTime  +  " tarihinde %  " 
                + campaign.CampaignDiscount + " indirim oranıyla sistemimize eklenmiştir. ");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine( campaign.CampaignName + " isimli kampanya " + campaign.CampaignDateTime + 
                " tarihinde sistemden silinmiştir. " ); 
           
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " isimli kampanya " + campaign.CampaignDateTime +
                 " tarihinde güncellenmiştir. ");
        }
    }
}
