using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IKredimanager da çalıştırır 
            //IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
           
            //IKrediManager  konutKrediManager = new KonutKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();
          
            //IKrediManager tasitKrediManager = new TasitKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            BasvuruManager basvuruManager = new BasvuruManager();


            ILoggerService datbaseLoggerService = new DataBaseLoggerService();
            FİleLoggerService fileloggerservice = new FİleLoggerService();



            basvuruManager.BasvuruYap(konutKrediManager, fileloggerservice);


            
           // hangi kodu yazarsan onun hesapalsaı çalıştırılır.

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager , tasitKrediManager};




           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);








        }
    }
}
