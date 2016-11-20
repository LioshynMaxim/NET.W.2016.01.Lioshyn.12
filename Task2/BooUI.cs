using System;
using System.Collections.Generic;
using System.IO;
using static Task2.BookUiHelpFunction;
using NLog;

namespace Task2
{
    public class BooUI
    {
        static void Main(string[] args)
        {
            OperationWithFile operationWithFile = new OperationWithFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "test.txt"));
            BookListService bookListService = new BookListService(operationWithFile);

            Book book1 = new Book("Есенин", "Первая книга", "Москва", 1955, 150);
            Book book2 = new Book("Пушкин", "Вторая книга", "Российская Империя", 1955, 150);
            

            BookUiHelpFunction bookUiHelpFunction = new BookUiHelpFunction(operationWithFile, bookListService);

            bookUiHelpFunction.AddBook(book1);
            bookUiHelpFunction.AddBook(book1);
            bookUiHelpFunction.RemoveBook(book2);
            bookUiHelpFunction.AddBook(book2);


            bookListService.SortsBooksByTag(book => book.Title);
            ServiceBookLogger.Info("Sorting internal list books by Title");
            DisplayBook(bookListService.BookList);

            List<Book> resultFind = bookListService.FindByTag(book => book.NumberOfPages == 189);
            ServiceBookLogger.Info("Find list book where number of page = 189");
            DisplayBook(resultFind);

            Console.ReadKey();
        }
    }
}
