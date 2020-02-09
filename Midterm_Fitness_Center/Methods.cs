﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm_Fitness_Center
{
    class Methods
    {
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        public static bool UserSelection(string message, string option1_true, string option2_false)
        {
            string select = GetUserInput(message).ToLower();

            while (select != option1_true && select != option2_false)
            {
                return UserSelection(message, option1_true, option2_false);
            }

            if (select == option1_true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string SingleOrMultiSelection()
        {

            bool singleOrMulti = UserSelection("Membership options: Single Club or Multi Club access? Enter: (s/m)", "s", "m");
            
            if (singleOrMulti)
            {
                return "single";
            }
            else
            {

                return "multi";
            }

        }

        public static int UserChoice(string msg, string errorMsg, int limit)
        {
            int userOption;

            // check if input is a valid integer
            if (int.TryParse(GetUserInput(msg), out userOption))
            {
                // check if integer input is valid
                if ((userOption <= 0) || (userOption > limit))
                {
                    Console.WriteLine(errorMsg);
                    return UserChoice(msg, errorMsg, limit);
                }
                return userOption;
            }
            else
            {
                // if option is NOT an integer
                Console.WriteLine(errorMsg);
                return UserChoice(msg, errorMsg, limit);
            }






        }

    }
}