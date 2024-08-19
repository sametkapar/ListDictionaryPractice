using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            //Console.WriteLine(books.Count);
            //Console.WriteLine(books.Capacity);

            //for (int i = 0; i < books.Count; i++)
            //{
            //    Console.WriteLine("İsim: "+books[i].bookName +"\nYazar: "+ books[i].bookAuthor +"\nTür: "+ books[i].bookType);
            //    Console.WriteLine("------");
            //}

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
                Console.WriteLine((i+1)+ ") "+Types[i]);
            }

        }
    }
}
