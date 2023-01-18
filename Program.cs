using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
     class Program
    {
        
        static void Main(string[] args)
        {
            List<int> CiftSayilar=new List<int>();
            List<int> BolunebilenSayiler=new List<int>();
            List<string>TerstenSıra=new List<string>();
            List<int> KelimeVeHarfSayisi=new List<int>();
      /*      CiftSayilar=Program.Quest1();
            for(int i=0;i<CiftSayilar.Count;i++){
                Console.WriteLine(i+1+".nci sayi:"+CiftSayilar[i]);  
            }

*/
         /*   BolunebilenSayiler=Program.Quest2();
            for(int i=0;i<BolunebilenSayiler.Count;i++){
                Console.WriteLine(i+1+".nci sayi:"+BolunebilenSayiler[i]);  
            }*/

         /*   TerstenSıra=Program.Quest3();
            TerstenSıra.Reverse();
            for(int i=0;i<TerstenSıra.Count;i++){
                Console.WriteLine(i+1+".nci sıra:"+TerstenSıra[i]);  
            }*/

            KelimeVeHarfSayisi=Program.Quest4();
            Console.WriteLine("Kelime Sayisi:"+KelimeVeHarfSayisi[0].ToString());
            Console.WriteLine("Harf Sayisi:"+KelimeVeHarfSayisi[1].ToString());
            
        }

        public static List<int> Quest1()
        {
            List<int> sayilar=new List<int>();
            Console.WriteLine("Sayı girin:");
            string t=Console.ReadLine();
            int x=Convert.ToInt32(t);
            if(x>0)
                {
                    
                        while(sayilar.Count<x)
                        {   Console.WriteLine(sayilar.Count+1+". sayıyı girin:");
                            int a=Convert.ToInt32(Console.ReadLine());
                            if(a>0)
                            {
                                if(a%2==0)
                                {
                                //Console.WriteLine("sayi:"+a);
                                sayilar.Add(a);

                                }
                            
                            }else{
                                Console.WriteLine("Pozitif sayi giriniz !!");
                            }

                        }
                    
                }

            return sayilar;
        }

        public static List<int> Quest2()
        {
            List<int> sayilar_M=new List<int>();
            List<int> sayilar=new List<int>();
            Console.WriteLine("Sayı girin-1:");
            string t=Console.ReadLine();
            int n=Convert.ToInt32(t);

            Console.WriteLine("Sayı girin-2:");
            string t2=Console.ReadLine();
            int m=Convert.ToInt32(t2);

            if(n>0)
                {
                    
                        while(sayilar.Count<n)
                        {   Console.WriteLine(sayilar.Count+1+". sayıyı girin:");
                            int a=Convert.ToInt32(Console.ReadLine());
                            if(a>0)
                            {
                                if(a%m==0 || a==m)
                                {
                                //Console.WriteLine("sayi:"+a);
                                sayilar_M.Add(a);

                                }
                                sayilar.Add(a);
                            
                            }else{
                                Console.WriteLine("Pozitif sayi giriniz !!");
                            }

                        }

                        
                    
                }

            if(sayilar_M.Count==0)
            {
               return sayilar;             
            }else{
                return sayilar_M;
            }
        }

        public static List<string> Quest3()
        {
            List<string> kelimeler=new List<string>();
            Console.WriteLine("Sayı girin:");
            string t=Console.ReadLine();
            int x=Convert.ToInt32(t);
            if(x>0)
                {
                    
                        while(kelimeler.Count<x)
                        {   Console.WriteLine(kelimeler.Count+1+". kelimeyi girin:");
                            string a=Console.ReadLine();
                           
                                kelimeler.Add(a);

                                }
                            
                           

                        }
                    
                

            return kelimeler;
        }

        public static List<int> Quest4()
        {
            List<int> kelimeler=new List<int>();
            Console.WriteLine("Cumle girin:");
            string cumle=Console.ReadLine();
            
            string[] bosluksuz=cumle.Split(' ');
            
            //int harfSay=bosluksuz.Length;
            //int kelimeSay=(cumle.Length-harfSay)+1;
            int karakter=cumle.Length;
            int kelimeSay=bosluksuz.Length;
            int bosluk=kelimeSay-1;
            int harfSay=karakter-bosluk;

            kelimeler.Add(kelimeSay);
            kelimeler.Add(harfSay);

            Console.WriteLine(harfSay+"#"+kelimeSay+"#"+bosluk);
           
                

            return kelimeler;
        }



    

       /* public class Quests{
            public static void Quest1(int x)
            {
                
                if(x>0)
                {
                    
                        for(int i=0;i<5;i++)
                        {   Console.WriteLine("5 adet sayı girin:");
                            int a=Console.ReadLine();
                            
                            if(a%2==0)
                            {
                            Console.WriteLine("sayi:"+a);
                            }

                        }
                    
                }
            }
        }*/
        
    }
}
