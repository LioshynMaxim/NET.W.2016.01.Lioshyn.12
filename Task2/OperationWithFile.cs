using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class OperationWithFile : IBookListStorage<Book>
    {
        #region Field

        /// <summary>
        /// Path to file.
        /// </summary>
        public string Path { get; }

        #endregion

        #region .ctor

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="path">Path to file.</param>

        public OperationWithFile(string path)
        {
            if (String.IsNullOrEmpty(path))
                throw new ArgumentException();

            Path = path;
        }

        #endregion

        #region Main operation

        /// <summary>
        /// Write books in file.
        /// </summary>
        /// <param name="listBookForWrite">List book.</param>

        public void WriteBooks(List<Book> listBookForWrite)
        {
            if (listBookForWrite == null)
                throw new ArgumentException();

            using (FileStream fs = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                foreach (Book t in listBookForWrite)
                {
                    writer.Write(t.Author);
                    writer.Write(t.Title);
                    writer.Write(t.NumberOfPages);
                    writer.Write(t.Publisher);
                    writer.Write(t.YearIssued);
                }
            }
        }

        /// <summary>
        /// Read books from file.
        /// </summary>
        /// <returns>Books list.</returns>

        public List<Book> ReadBooks()
        {
            List<Book> listBookForRead = new List<Book>();

            using (FileStream fs = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                while (reader.PeekChar() > -1)
                {
                    string author = reader.ReadString();
                    string title = reader.ReadString();
                    int numberOfPages = reader.ReadInt32();
                    string publisher = reader.ReadString();
                    int yearIssued = reader.ReadInt32();

                    listBookForRead.Add(new Book(author, title, publisher, numberOfPages, yearIssued));
                }
            }
            return listBookForRead;
        } 

        #endregion
        
    }
}
