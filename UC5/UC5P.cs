using System;
using System.Collections.Generic;
using System.Text;



namespace day21
{
    public class UC5P
    {
        public static string Regex_input = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d@$!%*#?&^_-]{8,8}$";
        public bool UC_5(string input)
        {

            
                if (input == null)
                {
                    throw new URegCustomException(URegCustomException.ExceptionType.INVALID_MESSAGE, "Invalid Input");
                }
                return System.Text.RegularExpressions.Regex.IsMatch(input, Regex_input);
            }
    }
    
}