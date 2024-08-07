
using PatikaWeek4Homework3;

// default constructor ile
Library library = new Library();
library.BookName = "Adı Aylin";
library.AuthorName = "Ayşe";
library.AuthorSurname = "Kulin";
library.Publisher = "Remzi Kitabevi";
library.PagesNumber = 398;
library.DisplayLibrary();

//parametreli constructor ile
Library library1 =new Library("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi") ;
library1.DisplayLibrary();

