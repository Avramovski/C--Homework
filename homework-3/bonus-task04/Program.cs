// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter email:");
        string email = Console.ReadLine();
        static bool EmailValidate(string email)
        {
            if (!email.Contains("@"))
            {
                Console.WriteLine("The mail must have \"@\" ");
                return false;
            }
            else if (!email.Contains("."))
            {
                Console.WriteLine("The mail must have \".\" ");
                return false;
            }

            int atThisIndex = email.IndexOf("@");
            int dotIndex = email.IndexOf(".");
            if (atThisIndex == -1 || atThisIndex == 0)
            {
                Console.WriteLine("you need text in front of @");
                return false;
            }
            else if (dotIndex < atThisIndex)
            {
                Console.WriteLine("@ must bi infront of .");
                return false;
            }
            else
            {
                return true;
            }



        }

Console.WriteLine(EmailValidate(email));