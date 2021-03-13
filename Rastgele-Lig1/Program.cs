using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Rastgele_Lig1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            Console.WriteLine("TURNUVA\n");
            Console.WriteLine("Bütün takımlara Elvangücü olarak başarılar dileriz...\n");
            int gs = 0;
            int fb = 0;
            int bjk = 0;
            int eg = 0;
            int sayac = 1;

            int g1, g2, g3;
            int f1, f2, f3;
            int b1, b2, b3;
            int e1, e2, e3;
            if (sayac==1)
            {
                Console.WriteLine("İLK HAFTA SKORLARI");
                Console.WriteLine("---------------------------------\n");
                g1 = rastgele.Next(0, 6);
                f1 = rastgele.Next(0, 6);
                b1 = rastgele.Next(0, 6);
                e1 = rastgele.Next(0, 6);
                Console.WriteLine("GALATASARAY "+g1+"-"+"FENERBAHÇE "+f1);
                if (g1>f1)
                {
                    gs = gs + 3;
                }
                if (g1<f1)
                {
                    fb = fb + 3;
                }
                if (g1==f1)
                {
                    fb = fb + 1;
                    gs = gs + 1;
                }
                Console.WriteLine("ELVANGÜCÜ "+e1+"-"+"BEŞİKTAŞ "+b1);
                if (e1> b1)
                {
                    eg = eg + 3;
                }
                if (e1 < b1)
                {
                    bjk = bjk + 3;
                }
                if (e1 == b1)
                {
                    eg = eg + 1;
                    bjk = bjk + 1;
                }
                sayac++;
                Console.ReadLine();

                
            }
            if (sayac==2)
            {
                Console.WriteLine("İKİNCİ HAFTA SKORLARI");
                Console.WriteLine("---------------------------------\n");
                g2 = rastgele.Next(0, 6);
                f2 = rastgele.Next(0, 6);
                b2 = rastgele.Next(0, 6);
                e2 = rastgele.Next(0, 6);
                Console.WriteLine("BEŞİKTAŞ "+b2+"-"+"GALATASARAY "+g2);
                if (b2>g2)
                {
                    bjk = bjk + 3;
                }
                if (b2<g2)
                {
                    gs = gs + 3;
                }
                if (b2==g2)
                {
                    bjk = bjk + 1;
                    gs = gs + 1;
                }
                Console.WriteLine("FENERBAHÇE "+f2+"-"+"ELVANGÜCÜ "+e2);
                if (f2>e2)
                {
                    fb = fb + 3;

                }
                if (f2<e2)
                {
                    eg = eg + 3;
                }
                if (e2==f2)
                {
                    eg = eg + 1;
                    fb = fb + 1;
                }
                sayac++;
                Console.ReadLine();
            }
            if (sayac==3)
            {
                Console.WriteLine("ÜÇÜNCÜ HAFTA SKORLARI");
                Console.WriteLine("---------------------------------\n");
                g3 = rastgele.Next(0, 6);
                f3 = rastgele.Next(0, 6);
                b3 = rastgele.Next(0, 6);
                e3 = rastgele.Next(0, 6);
                Console.WriteLine("ELVANGÜCÜ "+e3+"-"+"GALATASARAY "+g3);
                if (e3>g3)
                {
                    eg = eg + 3;
                }
                if (e3<g3)
                {
                    gs = gs + 3;
                }
                if (e3==g3)
                {
                    gs = gs + 1;
                    eg = eg + 1;
                }
                Console.WriteLine("BEŞİKTAŞ " + b3 +"-"+ "FENERBAHÇE " + f3);
                if (b3>f3)
                {
                    bjk = bjk + 3;
                }
                if (b3<f3)
                {
                    fb = fb + 3;
                }
                if (b3==f3)
                {
                    bjk = bjk + 1;
                    fb = fb + 1;
                }
                sayac++;
                Console.ReadLine();
                    

            }

            if (sayac==4)
            {
                Console.WriteLine("Maçlar bitti...\n");
                Console.WriteLine("SKOR TABLOSU\n");
                Console.WriteLine("--------------------");
                Console.WriteLine("ELVANGÜCÜ = "+eg);
                Console.WriteLine("GALATASARAY = "+gs);
                Console.WriteLine("BEŞİKTAŞ = "+bjk);
                Console.WriteLine("FENERBAHÇE = "+fb);
                Console.WriteLine();
                Console.WriteLine("---------------------------\n");
            }

            if (eg>gs && eg>fb && eg>bjk  )
            {
                Console.WriteLine("ŞAMPİYON ELVANGÜCÜ");
                SoundPlayer ses = new SoundPlayer(@"C:\Users\eşref\Desktop\MEDYA\sansi.wav");
                ses.Play();

            }
            if (gs>eg && gs>fb && gs>bjk)
            {
                Console.WriteLine("ŞAMPİYON GALATASARAY");
                SoundPlayer ses2 = new SoundPlayer(@"C:\Users\eşref\Desktop\MEDYA\sansi.wav");
                ses2.Play();
            }
            if (fb>eg && fb>gs && fb>bjk)
            {
                Console.WriteLine("ŞAMPİYON FENERBAHÇE");
                SoundPlayer ses3 = new SoundPlayer(@"C:\Users\eşref\Desktop\MEDYA\sansi.wav");
                ses3.Play();
            }
            if (bjk>eg && bjk>gs && bjk>fb)
            {
                Console.WriteLine("ŞAMPİYON BEŞİKTAŞ");
                SoundPlayer ses4 = new SoundPlayer(@"C:\Users\eşref\Desktop\MEDYA\sansi.wav");
                ses4.Play();
            }
            Console.ReadLine();
        }
    }
}
