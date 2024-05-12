class Program
{
    static void Main()
    {
        //display title
        System.Console.WriteLine("***bucketb0t Baank***");
        System.Console.WriteLine("::Login Page::");

        //variables to store username and password
        string userName = null, password = null;

        //read userName from keyboard
        System.Console.Write("Username: ");
        userName = System.Console.ReadLine();


        //read password from keyboard only if username is entered
        if (userName != "")
        {
            System.Console.Write("Password:");
            userName = System.Console.ReadLine();
        }

        //check username and password
        if (userName == "system" && password == "manager")
        {
            System.Console.WriteLine("TO Do: Main Menu Here");
        }

        //about to exit
        System.Console.WriteLine("Thank you! Visit again.");
        System.Console.ReadKey();
    }

}