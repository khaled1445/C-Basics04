namespace C_Basics04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // the rest of Assignment 3 
            #region Problem 1
            //.Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. 
            //Print both title and upperTitle to show that title did not change.
            string title = "clean code";
            string upperTitle = title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(upperTitle);
            #endregion

        }
    }
}
