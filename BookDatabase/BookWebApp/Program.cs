using BookWebApp.Models;
using BookWebApp;

//------insert book-----------
//Book book = new Book();
//{
//    book.BookName = "Sis ve Gece";
//    book.Author = "Ahmet Ümit";
//    book.PageNumber = 270;
//    book.Price = 56.10;
//};

//BookDataContext db = new BookDataContext();
//db.Books.Add(book);
//db.SaveChanges();

BookDataContext BookDb = new BookDataContext();
//----------get books-----------
//List<Book> books = BookDb.Books.ToList();

//foreach (Book book in books)
//{
//    Console.WriteLine($"BookName : {book.BookName} Author : {book.Author} PageNumber : {book.PageNumber} Price : {book.Price}");
//}
//var students = StudentDb.Students.Where(s => s.GPA > 2);
//foreach(Student student in students)
//{
//    Console.WriteLine($"Name : {{student.FirstName}} Lastname : {{student.LastName}} BirthDate : {{student.BirthDate.ToShortDateString}} GPA : {{student.GPA}}");
//}

//-------get book with id---------
//var book = BookDb.Books.Where(a => a.Id == 3).FirstOrDefault();
//if (book != null)
//{
//    Console.WriteLine($"BookName : {book.BookName} Author : {book.Author} PageNumber : {book.PageNumber} Price : {book.Price}");
//}
//else
//{
//    Console.WriteLine("Searched book is not found!");
//}

//--------update--------- 
//var book = BookDb.Books.Where(n => n.BookName == "Cemile").FirstOrDefault();
//book.Price = 15.00;
//BookDb.SaveChanges();


