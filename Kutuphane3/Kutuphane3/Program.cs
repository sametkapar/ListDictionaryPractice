using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kutuphane3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Kitap> books = new List<Kitap>();
            books.Add(new Kitap() { bookName = "Kaşağı", bookAuthor = "Ömer Seyfettin", bookType = "Hikaye" });
            books.Add(new Kitap() { bookName = "Yüzüklerin Efendisi", bookAuthor = "J.R.R. Tolkein", bookType = "Roman" });
            books.Add(new Kitap() { bookName = "Sefiller", bookAuthor = "Victor Hugo", bookType = "Roman" });
            books.Add(new Kitap() { bookName = "Death Note", bookAuthor = "Japon", bookType = "Manga" });
            books.Add(new Kitap() { bookName = "Bleach", bookAuthor = "Japon2", bookType = "Manga" });
            books.TrimExcess();

            List<Kullanicilar> users = new List<Kullanicilar>();
            users.Add(new Kullanicilar() { userName = "admin", password = "1234" });
            users.Add(new Kullanicilar() { userName = "samet", password = "0000" });

            Console.WriteLine("Kütüphaneye Hoş geldiniz");

            Console.WriteLine("Kullanıcı adınızı ve şifrenizi giriniz");
            Console.Write("Kullanıcı adı = ");
            string kullanici = Console.ReadLine();




            if (kullanici == users[0].userName)
            {
                Console.Write("Şifre = ");
                string sifre = Console.ReadLine();
                if (sifre == users[0].password)
                {
                    Console.WriteLine("Admin girişi yapıldı. Lütfen yapmak istediğiniz işlemi seçiniz");
                    Console.WriteLine("1) Kitap Ekleme");
                    Console.WriteLine("2) Kütüphaneyi Kapatma");
                }
                else
                {
                    Console.WriteLine("Sifre hatalı");
                }

            }
            else if (kullanici == users[1].userName)
            {
                Console.Write("Sifre = ");
                string sifre = Console.ReadLine();
                if (sifre == users[1].password)
                {
                    Console.WriteLine("Girişi yapıldı. Lütfen yapmak istediğiniz işlemi seçiniz");
                    Console.WriteLine("1) Kitap Listesi");
                    Console.WriteLine("2) Türe Göre Kitap listesi");
                    string secim = Console.ReadLine();
                    if (secim == "1")
                    {
                        for (int i = 0; i < books.Count; i++)
                        {
                            Console.WriteLine("İsim: " + books[i].bookName + "\nYazar: " + books[i].bookAuthor + "\nTür: " + books[i].bookType);
                            Console.WriteLine("------");
                        }
                    }

                    else if (secim == "2")
                    {
                        List<string> Types = new List<string>();


                        for (int i = 0; i < books.Count; i++)
                        {
                            bool isIn = false;
                            for (int j = 0; j < Types.Count; j++)
                            {
                                if (books[i].bookType == Types[j])
                                {
                                    isIn = true;
                                    break;
                                }
                            }
                            if (isIn == false)
                            {
                                Types.Add(books[i].bookType);
                            }
                        }

                        for (int i = 0; i < Types.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ") " + Types[i]);

                        }
                        Types.TrimExcess();
                        Console.WriteLine("----------");
                        Console.WriteLine("Seçmek istediğiniz tür");

                        int secim2 = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < books.Count; i++)
                        {
                            if (secim2 == (i + 1))
                            {
                                Console.WriteLine(Types[i] + " türüne ait kitaplar\n");
                                for (int j = 0; j < books.Count; j++)
                                {
                                    if (books[j].bookType == Types[i])
                                    {
                                        Console.WriteLine(books[j].bookName);
                                    }
                                }
                            }

                        }
                    }
                }
                else
                {
                    Console.WriteLine("Sifre hatalı");
                }
            }

        }
    }
}
