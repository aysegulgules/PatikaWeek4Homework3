using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PatikaWeek4Homework3
{
    public class Library
    {
        //Kütüphane nesnesinin property'leri tanımlanıyor..
        public string BookName { get; set; }
        public string AuthorName { get; set; } 
        public string AuthorSurname { get; set; } 
        public int PagesNumber { get; set; }
        public string Publisher { get; set; }
        public DateTime RegistrationDate { get; private set; }

        //Default constructor
        public Library()
        {
            initialize();
            
        }

        //Parametreli constructor
        public Library(string bookName, string authorName, string authorSurname, int pagesNumber ,string publisher )
        {
             BookName = bookName;
            AuthorName = authorName;
            AuthorSurname = authorSurname;
            PagesNumber = pagesNumber;
            Publisher = publisher;
            initialize();
        }
        
        private void initialize()
        {
            RegistrationDate = DateTime.Now;
        }

        public void DisplayLibrary()
        {
            Console.WriteLine($"\n Kitap Adı..: {BookName}\n Yazar Adı-Soyadı..: {AuthorName} {AuthorSurname}" +
                $" \n Sayfa Sayısı..: {PagesNumber}\n Yayınevi..: {Publisher}\n Kayit Tarihi..: {RegistrationDate.ToShortDateString()} ");

        }
        
    }
    
}
/* Class: Bir nesneyi tanımlar. Nesnenin özelliklerini ve işlevlerine karşılık gelen metodları içerir
 * Property: Nesnelerin özellikleridir.Class da PascalCase isimlendirme kuralına göre tanımlanır.
 * New: bir classdan yeni bir nesne oluşturmak için kullanılır.
 * Constructor: Nesne oluşturulduğu anda çalışır. Nesneye varsayılan değerler ayarlamasını, örneklemeyi sınırlamasını, esnek ve okunması kolay kod yazmasını sağlar.
 */