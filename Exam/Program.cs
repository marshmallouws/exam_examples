namespace Exam
{
    public class Exceptions
    {
        public static int TestException(string input)
        {

            var parsed = int.Parse(input);
            if (parsed == 0)
            {
                throw new TestException("i cannot be 0");
            }
            return parsed;
        }

        static void Main(String[] args)
        {


            Console.WriteLine("input number:");
            string input = Console.ReadLine();
            try
            {
                var i = TestException(input);
            }
            catch (TestException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Some other exception {e.Message}");
            }
   
            Console.WriteLine("continue");
            Console.ReadLine();
            Console.WriteLine("-----------------");

            var books = new List<Book>
            {
                new Book("Stephen King", "IT"),
                new Book("Stephen King", "Mute"),
                new Book("Lise", "Bo og Lis"),
                new Book("Lars", "Larsen")
            };

            Console.WriteLine("All books: ");
            foreach (var b in books)
            {
                Console.WriteLine($"{b.Author} - {b.Name}");
            }

            Console.ReadLine();
            Console.WriteLine("\nOnly Stephen King: ");
            var stephen = books.Where(b => b.Author.Equals("Stephen King")).ToList();
            foreach (var b in stephen)
            {
                Console.WriteLine($"{b.Author} - {b.Name}");
            }
        }
    }
}
