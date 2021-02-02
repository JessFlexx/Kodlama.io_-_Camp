namespace GameBackendDemo
{
    partial class Program
    {
        static void Main(string[] args)
        {

            //Customer
            Player customer1 = new Player();
            customer1.FirstName = "Talha Burak";
            customer1.LastName = "Aydın";                     //(AD - (VARSA DİĞER ADLARINIZIDA GİRİN) - SOYAD - TC - DOĞUM TARİHİNİ DOĞRU GİRMENİZ GEREKİYOR) 
            customer1.Password = "200399asd";                 // DOĞRU BİLGİLER GİRİLDİĞİNDE MERNİS TC DOĞRULAMA SERVİSİ SAYESİNDE 
            customer1.Id = "1";                               // KAYIT İŞLEMİ BAŞARI İLE GERÇEKLEŞTİ Yazısı EKRANDA GÖRÜNECEKTİR
            customer1.NationalityId = "10000000000";          // YANLIŞ BİLGİ GİRİŞİ OLURSA PROGRAM KENDİNİ DURDURUR     
            customer1.DateOfBirth = new System.DateTime(1995, 5, 25);
            customer1.Nick = "StrongHead123";
            customer1.Gold = 125850;
            ///////////////////////////////////
            //Player customer2 = new Player();
            //customer2.FirstName = "Melih";
            //customer2.LastName = "Kara";
            //customer2.Password = "205399asd";
            //customer2.Id = "2";
            //customer2.NationalityId = "1000000000";
            //customer2.DateOfBirth = new System.DateTime(2001, 1, 11);
            //customer1.Nick = "StrongMan1234";
            //customer1.Gold = 55670;

            //MarketPlace
            Product product1 = new Product();
            product1.ItemId = "1";
            product1.ItemName = "Big Sword";
            product1.ItemPrice = 12500;
            /////////////////////////////
            Product product2 = new Product();
            product2.ItemId = "2";
            product2.ItemName = "Huge Trol Armor";
            product2.ItemPrice = 25750;
            ///////////////////////////
            Product product3 = new Product();
            product3.ItemId = "3";
            product3.ItemName = "HeadSmasher Mace";
            product3.ItemPrice = 17450;

            //Campaigns
            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = "1";
            campaign1.CampaignName = "Hallowen Campaign";
            campaign1.AmountOfDiscount = 40;
            ////////////////////////////////
            Campaign campaign2 = new Campaign();
            campaign2.CampaignId = "2";
            campaign2.CampaignName = "Winter Campaign";
            campaign2.AmountOfDiscount = 30;



            BaseCustomerManager customerManager = new CustomerManager(new MernisAdapter());
            customerManager.Save(customer1);
            //ustomerManager.Save(customer2);
            customerManager.Delete(customer1);
            //customerManager.Update(customer2);

            BaseMarketManager marketManager = new BaseMarketManager();
            marketManager.Add(product1);
            marketManager.Buy(product2);
            marketManager.Sell(product3);
            marketManager.Discount(product1, campaign1);
            marketManager.Discount(product2, campaign2);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign2);
            campaignManager.Update(campaign1);







        }
    }
}
