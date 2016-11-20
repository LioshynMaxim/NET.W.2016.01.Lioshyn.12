using System.Collections.Generic;

namespace Task2
{
    public interface IBookListStorage<T>
    {
        void WriteBooks(List<T> books);
        List<T> ReadBooks();
    }
}