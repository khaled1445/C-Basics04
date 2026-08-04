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
        }
    }
}
