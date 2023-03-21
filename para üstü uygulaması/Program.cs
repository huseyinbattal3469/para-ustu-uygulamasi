using System;
using System.Threading;

namespace para_üstü_uygulaması
{
   
    class Program
    {

        static void Main(string[] args)
        {
            int[] banknotAdet = { 200, 100, 50, 20, 10, 5, 1 };
            int banknotAdetCarpan;
            int banknotAdetToplam=0;
                Console.WriteLine("Para Uygulaması'na hoş geldin! Uygulamaya başlamadan önce ATM'ye günlük nakit koymamız gerekiyor.\n200,100,50,20,10,5 ve 1 TL'lik banknot/madeni paraların yerleştirilmesi gerekiyor.");
                for (int p = 0; p < 7; p++)
                {
                    Console.Write("ATM'ye yerleştirilecek " + banknotAdet[p] + " TL'nin adetini giriniz: ");
                    banknotAdetCarpan = Convert.ToInt32(Console.ReadLine());
                    banknotAdet[p] *=banknotAdetCarpan;
                    banknotAdetToplam += banknotAdet[p];
                }
            int banknotAdetToplamYedek = banknotAdetToplam;

            start:
                Console.WriteLine("*********************************************************************************");
                Console.WriteLine(@"  _____                  _    _                   _                             ");
                Console.WriteLine(@" |  __ \                | |  | |                 | |                            ");
                Console.WriteLine(@" | |__) |_ _ _ __ __ _  | |  | |_   _  __ _ _   _| | __ _ _ __ ___   __ _ ___ _ ");
                Console.WriteLine(@" |  ___/ _` | '__/ _` | | |  | | | | |/ _` | | | | |/ _` | '_ ` _ \ / _` / __| |");
                Console.WriteLine(@" | |  | (_| | | | (_| | | |__| | |_| | (_| | |_| | | (_| | | | | | | (_| \__ \ |");
                Console.WriteLine(@" |_|   \__,_|_|  \__,_|  \____/ \__, |\__, |\__,_|_|\__,_|_| |_| |_|\__,_|___/_|");
                Console.WriteLine(@"                                 __/ | __/ |                                    ");
                Console.WriteLine(@"                                |___/ |___/                                     ");
                Console.WriteLine("*********************************************************************************");
                Console.Write("Lütfen çekmek istediğiniz tutarı giriniz.\nParanız 1TL'lik bozuk para ve 5TL, 10TL, 20TL, 50TL, 100TL, 200TL'lik banknotlarla teslim edilecektir:");
                int x = Convert.ToInt32(Console.ReadLine());

                if (x < 0)
                {
                    Console.WriteLine("UYARI! Hatalı giriş yaptınız. Uygulama yeniden başlatılıyor...");
                    Thread.Sleep(TimeSpan.FromSeconds(4));
                    Console.Clear();
                    goto start;
                }
                else if (x > banknotAdetToplam)
                {
                    Console.WriteLine("UYARI! Çekmek istediğin tutar tüm ATM'nin sahip olduğu paradan büyük. En fazla çekebileceğiniz tutar: " + banknotAdetToplam + " TL'dir.\nUygulama yeniden başlatılıyor...");
                    Thread.Sleep(TimeSpan.FromSeconds(4));
                    Console.Clear();
                    goto start;
                }

                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("Bankadan çekmek istediğiniz tutar: " + x + "TL.\nÇekme işlemi tamamlandı. Paranız;\n");
                banknotAdetToplam = 0;
                int[] banknotCekilen = { 200, 100, 50, 20, 10, 5, 1 };
                for (int i = 0; i < banknotCekilen.Length; i++)
                {
                    int x_banknotAdet = x / banknotCekilen[i];
                    if ((x_banknotAdet <= banknotAdet[i] / banknotCekilen[i]))
                    {
                       
                        Console.WriteLine(x_banknotAdet + " adet " + banknotCekilen[i] + "TL,");
                        banknotAdet[i] =banknotAdet[i] - (banknotCekilen[i] * x_banknotAdet);
                        banknotAdetToplam += banknotAdet[i];
                        x = x - banknotCekilen[i] * x_banknotAdet;

                    }
                    else if ((x_banknotAdet > banknotAdet[i] / banknotCekilen[i]) )
                    {
                        if(banknotAdet[i] < x_banknotAdet)
                        {
                        Console.WriteLine("Size teslim edilmesi gereken miktar {0} adet {1}TL, ATM'de kalan banknot adedi ise {2} adet {3}TL'dir.\nİşleminiz iptal edilmiştir... Kartınızı almayı unutmayınız...", x_banknotAdet,banknotCekilen[i],banknotAdet[i]/banknotCekilen[i],banknotCekilen[i]);
                        banknotAdetToplam = banknotAdetToplamYedek;
                        goto secim;                        
                        }
                        while (x_banknotAdet != banknotAdet[i] / banknotCekilen[i])
                        {
                            
                            x_banknotAdet--;
                        }
                       Console.WriteLine(x_banknotAdet + " adet " + banknotCekilen[i] + "TL,");
                        banknotAdet[i] = banknotAdet[i] - (banknotCekilen[i] * x_banknotAdet);
                        banknotAdetToplam += banknotAdet[i];
                        x = x - banknotCekilen[i] * x_banknotAdet;

                    }
                    Console.WriteLine();
                }
                Console.WriteLine("şeklinde teslim edilmiştir. Kartınızı geri almayı unutmayın.");
                secim:  
                Console.WriteLine("------------------------------------------------------------");
                Console.Write("Uygulamayı kapatmak için 0'ı, tekrar para çekmek için 1'i tuşlayınız: ");
                string secim = Console.ReadLine();
                if (secim == "1")
                {

                    Console.WriteLine("Uygulama yeniden başlatılıyor...");
                    Thread.Sleep(TimeSpan.FromSeconds(3));
                    Console.Clear();
                    x = 0;
                    goto start;
                }
                else if (secim == "0")
                {
                    Console.WriteLine("Uygulamayı kapatmak için herhangi bir tuşa basın...");

                }
                Console.ReadKey();
            
        }
    }
}
