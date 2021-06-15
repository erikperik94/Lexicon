using System;

namespace _2._0HangmanAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            int tries = 10;
            string[] words = { "VOLVO", "BMW", "FORD", "DODGE", "MAZDA" };
            System.Random random = new System.Random();
            int num = random.Next(words.Length);

            //Get the word and let the user see the length
            string secretname = words[num];
            secretname.ToUpper();
            bool score = GetProgram(secretname, tries);
            if(score == true)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Failure!");
            }
        }//end of Main

        static string GetSecretLook(string secretname,int count)
        {
            string secretlook = "";
            if (count == 0)
            {
                foreach (char s in secretname)
                {
                    secretlook = secretlook + " _ ";
                }
            }
            else
            {
                foreach (char s in secretname)
                {
                    if (s == '_')
                    {
                        secretlook = secretlook + " _ ";
                    }
                    else
                    {
                        secretlook = secretlook + string.Format(" {0} ",s);
                    }
                }
            }
            
            return secretlook;
        }
        static string GetInput(string old_inputs)
        {
            string mixedinput = Console.ReadLine();
            string capital_input = mixedinput.ToUpper();
            if(capital_input.Length > 1)
            {
                return capital_input;
            }

            //If user want to continue and didnt press enter
            if (capital_input != "")
            {
                string result_input = capital_input.Substring(0, 1);
                if(old_inputs.Contains(result_input) == false)
                {
                    return result_input;
                }
                else
                {
                    while(true)
                    {
                        Console.WriteLine(string.Format("Try another letter than {0}", old_inputs));
                        mixedinput = Console.ReadLine();
                        if (mixedinput == "")
                            return "";
                        capital_input = mixedinput.ToUpper();
                        result_input = capital_input.Substring(0, 1);
                        if (old_inputs.Contains(result_input) == false)
                            return result_input;
                    }
                }
                
            }
            //If user want to quit and pressed enter
            else
            {
                string result_input = capital_input;
                return result_input;
            }

        }

        static bool GetProgram(string secretname,int tries)
        {
            int count = 0;
            string old_inputs = "";
            string secretlook = GetSecretLook(secretname,count);
            for (int i = 0; i < tries; ++i)
            {
                count = 1;
                //Show how many tries user has left
                Console.WriteLine(string.Format("{0}   Try {1} of {2}: You have already tried {3}", secretlook, i, tries, old_inputs));

                //Continue or Quit checkpoint
                string result_input = GetInput(old_inputs);
                old_inputs = old_inputs + result_input;
                if (result_input == "")
                {
                    Console.WriteLine(string.Format("The word as: \"{0}\". Press any key to quit.", secretname));
                    Console.ReadKey();
                    return false;
                }

                //Replace every space with nothing
                secretlook = secretlook.Replace(" ", "");
                //Take users input into a list
                char[] result_charArr = result_input.ToCharArray();
                //Console.WriteLine(string.Format("RESULT {0}", result_charArr[0]));
                //Take secret name into a list, these we're going to use later for comparing
                char[] name_charArr = secretname.ToCharArray();
                //Take secret look into a list, these are those we want to replace later
                char[] look_charArr = secretlook.ToCharArray();

                //foreach (char c in name_charArr)
                for (int j = 0; j < name_charArr.Length; ++j)
                {
                    char c = name_charArr[j];
                    foreach (char u in result_charArr)
                    {
                        if (c == u)
                        {
                            look_charArr[j] = c;
                        }
                    }
                }
                
                secretlook = new string(look_charArr);
                secretlook = GetSecretLook(secretlook, count);

                if (secretlook.Contains("_") == false)
                {
                    Console.WriteLine(string.Format("{0}   Try {1} of {2}: ", secretlook, i, tries));
                    return true;
                }
                else if(secretlook.Contains("_") == true && i == (tries - 1))
                {
                    Console.WriteLine(string.Format("{0}   Try {1} of {2}: ", secretlook, i, tries));
                    return false;
                }
            }
        return false;
        }
    }

}