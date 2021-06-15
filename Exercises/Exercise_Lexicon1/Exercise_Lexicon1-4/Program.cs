using System;

namespace Exercise_1_Lexicon
{
    class Program
    {
        static void Main(string[] args)
        {
            var keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assignment number(or -1 to exit): ");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            string[] stored_name = RunExerciseThree();
                            for (int i = 0; i < stored_name.Length; i++)
                            {
                                string s = stored_name[i];
                                if((stored_name.Length - 1) > i)
                                {
                                    Console.Write(String.Format("{0} ", s));
                                }
                                else
                                {
                                    Console.WriteLine(String.Format("{0} ", s));
                                }
                            }
                            break;
                        case 4:
                            RunExerciseFour();

                            break;

                            Console.WriteLine("");
                            break;
                        case -1:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number!");
                            break;

                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid assignment number!");
                    Console.ResetColor();
                }
            }
        }//End of Main
        private static void RunExerciseOne()
        {
            Console.WriteLine("Write your first name");
            string first_name = Console.ReadLine();
            string first_name_text = String.Format("Hello {0} write your lastname", first_name);
            Console.WriteLine(first_name_text);
            string last_name = Console.ReadLine();
            string name_text = String.Format("Hello {0} {1}", first_name, last_name);

            Console.WriteLine(name_text + ", you successfully ran exercise one!");
        }
        private static void RunExerciseTwo()
        {
            DateTime today = DateTime.Now;
            DateTime tomorrow = today.AddDays(1);
            DateTime yersterday = today.AddDays(-1);
            Console.WriteLine("Today: {0:dd}", today);
            Console.WriteLine("Tomorrow: {0:dd}", tomorrow);
            Console.WriteLine("Yersterday: {0:dd}", yersterday);
        }
        private static string[] RunExerciseThree()
        {
            Console.Write("Write your first name: ");
            string first_name = Console.ReadLine();
            Console.Write("Write your last name: ");
            string last_name = Console.ReadLine();

            string[] stored_name = new string[] { first_name, last_name };

            return stored_name;
        }

        private static void RunExerciseFour()
        {
            string str = "The quick fox Jumped Over the DOG";
            str = str.Remove(4, 5); //Remove quick
            str = str.Insert(4, "brown"); //Insert brown
            str = str.Insert(29, " lazy");//Insert lazy -4??
            str = str.Substring(0,1).ToUpper() + str.Substring(1).ToLower();
            
            //"The brown fox jumped over the lazy dog"
            Console.WriteLine(str);
        }

    }

}
