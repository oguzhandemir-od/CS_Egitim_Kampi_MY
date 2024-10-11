﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If - Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password = Console.ReadLine();

            //if(password=="abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if(capital=="ankara" & country=="türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bilgi");
            //}

            //int number;
            //Console.Write("Sayıyı giriniz: ");
            //number=int.Parse(Console.ReadLine());

            //if(number==5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "";

            //Console.Write("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç çok iyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username=Console.ReadLine();

            //if(username!="admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez!");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz!");
            //}
            #endregion

            #region Mode Operations

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("1. sayının 2. sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //if(number%2==0)
            //{
            //    Console.WriteLine("Sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir");
            //}

            #endregion

            #region Example 1

            char team;
            Console.Write("Lütfen takım sembolünü giriniz: ");
            team = char.Parse(Console.ReadLine());

            if (team == 'g' | team == 'G')
            {
                Console.WriteLine("Galatasaray");
            }
            if (team == 'f' | team == 'F')
            {
                Console.WriteLine("Fenerbahçe");
            }
            if (team == 'b' | team == 'B')
            {
                Console.WriteLine("Beşiktaş");
            }
            #endregion

            #region Example 2

            Console.Write("****** C# Eğitim Kampı Restoran ******");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1-Ana Yemekler");
            Console.WriteLine("2-Çorbalar");
            Console.WriteLine("3-Pizzalar");
            Console.WriteLine("4-İçecekler");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("-----------------------------------");

            string menuItem;
            Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            menuItem= Console.ReadLine();

            if(menuItem=="1")
            {
                Console.WriteLine();
                Console.WriteLine("----------Ana Yemekler----------");
                Console.WriteLine();
                Console.WriteLine("1-Köri Soslu Tavuk");
                Console.WriteLine("2-Kızartma Tabağı");
                Console.WriteLine("3-Fasulye Pilav");
                Console.WriteLine("4-Fırında Somon");
                Console.WriteLine("5-Patlıcan Musakka");
                Console.WriteLine("----------Ana Yemekler----------");
                Console.WriteLine();
            }
            if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("----------Çorbalar----------");
                Console.WriteLine();
                Console.WriteLine("1-Mercimek Çorbası");
                Console.WriteLine("2-Ezogelin Çorbası");
                Console.WriteLine("----------Çorbalar----------");
                Console.WriteLine();
            }
            if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("----------Pizzalar----------");
                Console.WriteLine();
                Console.WriteLine("1-Akdeniz Pizza");
                Console.WriteLine("2-Margarita");
                Console.WriteLine("3-Tavuklu Pizza");
                Console.WriteLine("----------Pizzalar----------");
                Console.WriteLine();
            }
            if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("----------İçecekler----------");
                Console.WriteLine();
                Console.WriteLine("1-Kola");
                Console.WriteLine("2-Ayran");
                Console.WriteLine("3-Su");
                Console.WriteLine("----------İçecekler----------");
                Console.WriteLine();
            }
            if (menuItem == "5")
            {
                Console.WriteLine();
                Console.WriteLine("----------Tatlılar----------");
                Console.WriteLine();
                Console.WriteLine("1-Trileçe");
                Console.WriteLine("2-Kazandibi");
                Console.WriteLine("3-Sütlaç");
                Console.WriteLine("----------Tatlılar----------");
                Console.WriteLine();
            }


            #endregion
            Console.ReadKey();
        }
    }
}
