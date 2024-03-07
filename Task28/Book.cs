namespace Task28
{
    public class Book
    {
        private static int _booksCount = 0;

        public Book()
        {
            _booksCount++;
        }

        public static int countInstances()
        {
            return _booksCount;
        }
    }
}