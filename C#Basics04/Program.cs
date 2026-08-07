using System.Text;

namespace C_Basics04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // the rest of Assignment 3 
            #region Problem 1
            ////.Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. 
            ////Print both title and upperTitle to show that title did not change.
            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);
            #endregion

            #region Problem 2
            //Declare two separate string variables, both set to the literal "Clean Code".
            //Use ReferenceEquals() to check if they point to the same object in memory.

            //string str1 = "Clean Code";
            //string str2 = "Clean Code";
            //if (ReferenceEquals(str1, str2)) 
            //{ 
            //Console.WriteLine("string 1 and string 2 refers to the same object: " + ReferenceEquals(str1, str2));
            //}
            #endregion

            #region Problem 3
            ////.Create a StringBuilder, Append() the text "Book List",
            ////then Append() " - Updated" onto the same object. Print the final result
            //StringBuilder sb01 = new StringBuilder();
            //sb01.Append("Book List");
            //sb01.Append(" - Updated");
            //Console.WriteLine(sb01);
            #endregion

            #region Problem 4
            ////Using the StringBuilder from the question above,use Replace() to change "Book List" into "Library".Print the result
            //StringBuilder sb01 = new StringBuilder();
            //sb01.Append("Book List");
            //sb01.Append(" - Updated");
            //sb01.Replace("Book List","Library");
            //Console.WriteLine(sb01);
            #endregion

            #region Problem 5
            ////.Given string title = "Clean Code"; and int pages = 464;
            ////, build the sentence "Book: Clean Code, Pages: 464" using the + operator
            //string title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine("Book: " + title +"||"+ "pages: " + pages);
            #endregion

            #region Problem 6  
            ////Build the same sentence as above, but using string interpolation ($"...").
            //string title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine($"Book: {title}, Pages: {pages}");
            #endregion

            #region Problem 7
            ////Build the same sentence as above, but using string.Format().
            //string title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine(string.Format("Book: {0}, Pages: {1}", title, pages));
            #endregion

            #region Problem 18
            //.Write a method PrintFirstBook() that prints the first book in the books array.
            //If the array is empty, use return to exit the method early instead of printing anything.

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //string PrintFirstBook(string[] books)
            //{
            //    if (books.Length == 0)
            //    {
            //        return "The array is empty.";
            //    }
            //    else
            //    {
            //        return books[0];
            //    }
            //}

            //Console.WriteLine(PrintFirstBook(books));

            #endregion

            //Assignment04

            #region Problem 1
            ////Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print the second price (index 1).
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);
            #endregion

            #region Problem 2
            ////Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and shelf 1 has 1, 4 copies
            ////. Print the number of copies on shelf 1, slot 0.
            //int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            //Console.WriteLine(shelfCopies[1, 0]);
            //Console.WriteLine(shelfCopies[1, 1]);
            #endregion

            #region Problem 3
            ////Write a method called PrintWelcomeMessage that takes no parameters and prints "Welcome to the Library!".
            ////Call it from Main.

            //string PrintWelcomeMessage() 
            //{
            //    return "Welcome to the Library!"; 
            //}
            //Console.WriteLine(PrintWelcomeMessage());
            #endregion

            #region Problem 4 
            ////Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with "Clean Code"
            //string PrintBookTitle(string title) 
            //{
            //    return "book title: " + title;
            //}
            //Console.WriteLine(PrintBookTitle("Clean Code"));
            #endregion
        }
    }
}
