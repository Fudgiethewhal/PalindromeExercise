using System;
using System.Linq;

namespace PalindromeExercise;

public class WordSmith
{
    public bool IsAPalindrome(string input)
    {
       var reversed = "";

       for (int i = input.Length - 1; i >= 0; i--)
       {
           reversed += input.ToLower()[i];
       }

       if (reversed == input.ToLower())
       {
           return true;
       }
       else
       {
           return false;
       }
       return input.ToLower().SequenceEqual(input.ToLower().Reverse());
    }
}