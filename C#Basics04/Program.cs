using System.Reflection;
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

            #region Problem 5
            ////Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable int pages = 400;
            ////and print pages afterward. What do you expect to see, and why?
            //int AddBonusPages(int pages) 
            //{
            //    return pages + 50;
            //}
            //Console.WriteLine(AddBonusPages(400));
            #endregion

            #region Problem 6
            //Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0].
            //Call it with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward. What do you expect to see, and why?
            //i'll see 20.5 because the method modifies the original array, and arrays are reference types in C#.

            //static void ApplyDiscount(double[] prices)
            //{
            //    prices[0] -= 5;

            //}

            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);
            #endregion

            #region Problem 7
            //Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
            //Call it and print pages afterward. How is the result different from question 5?
            //int AddddbonusPages(ref int pages) 
            //{
            //    return pages + 50;
            //}
            //int pages = 400;
            //Console.WriteLine(AddddbonusPages(ref pages));
            //Console.WriteLine("==============================");
            //Console.WriteLine(pages);
            ////The result is different from question 5 because the ref keyword allows the method to modify the original variable
            ////Not the reference, so the value of pages is updated to 450 after the method call.
            #endregion

            #region Problem 8
            //Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a new array { 10.0, 12.5, 15.0 }
            //. Call it with your prices array and print prices.Length afterward.

            //static void ReplaceArraay(ref double[] prices)
            //{
            //    prices = new double[] { 10.0, 12.5, 15.0 };
            //}
            //double[] prices = {1.0, 2.0, 3.0, 4.0, 5.0, 6.0};
            //ReplaceArraay(ref prices);
            //Console.WriteLine(prices.Length);
            #endregion

            #region Problem 9
            //Write a method bool TryGetPrice(string title,out double price)that returns true and sets price to 25.5 if title is"Clean Code",
            //otherwise returns false and sets price to 0. Call it and print the price if found
            //static bool TryGetPrice(string title, out double price) 
            //{
            //    if (title == "Clean Code")
            //    {
            //        price = 25.5;
            //        return true;
            //    }
            //    else 
            //    {
            //        price = 0.0;
            //        return false;
            //    }

            //}
            //Console.WriteLine(TryGetPrice("Clean Code",out double price));
            //Console.WriteLine("Price is " + price);

            #endregion

            #region Problem 10
            ////Write a method PrintBookInfo(string title, int pages = 300) where pages is optional.
            ////Call it once with only a title, and once passing both a title and pages.
            //static void PrintBookInfo(string title, int pages = 300) 
            //{
            //    Console.WriteLine($"book title is {title} it's {pages} pages");
            //}
            //PrintBookInfo("Clean Code");
            //PrintBookInfo("C#", 250);
            #endregion
        }
    }
}
