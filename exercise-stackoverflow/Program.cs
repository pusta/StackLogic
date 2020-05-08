using System;
using System.Reflection.Metadata;

namespace exercise_stackoverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var stacklogic = new StackLogic();

            while (true)
            {
                Console.WriteLine(System.Environment.NewLine + stacklogic.PostTitle() + System.Environment.NewLine + stacklogic.PostContent() + System.Environment.NewLine);
                Console.WriteLine("Current vote: " + stacklogic.PostScore);
                Console.WriteLine("{0} Upvotes and {1} Downvotes", stacklogic.GetUpVote(), stacklogic.GetDownVote());
                Console.WriteLine("Please select an option below:");
                Console.WriteLine("1. Upvote Post: ");
                Console.WriteLine("2. Downvote Post: ");
                Console.WriteLine("3. Exit");
                Console.Write("Selection: ");
                var input = Console.ReadLine();

                if ((String.IsNullOrWhiteSpace(input)) || (Convert.ToInt32(input) == 3))
                    break;

                else if (Convert.ToInt32(input) == 1)
                {
                    stacklogic.UpVote();
                }

                else
                {
                    stacklogic.DownVote();
                }



            }
        }
    }
}
