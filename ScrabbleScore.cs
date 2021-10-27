using System;
using System.Collections.ObjectModel;
using System.Linq;

public static class ScrabbleScore
{
    public static int Score(string input)
    { 
       int points = 0;
       string inputUpper = input.ToUpper();

       var letter1Point = new[]  { "A", "E", "I", "O", "U", "L", "N", "R", "S", "T" };
       var letter2Point = new[] { "D", "G" };
       var letter3Point = new[] { "B", "C", "M", "P" };
       var letter4Point = new[] { "F", "H", "V", "W", "Y" };
       var letter5Point = new[] { "K" };
       var letter8Point = new[] { "J","X" };
       var letter10Point = new[] { "Q", "Z"};

       foreach (char ch in inputUpper)
       {
           if (letter1Point.Contains(ch.ToString())) points += 1;
           if (letter2Point.Contains(ch.ToString())) points += 2;
           if (letter3Point.Contains(ch.ToString())) points += 3;
           if (letter4Point.Contains(ch.ToString())) points += 4;
           if (letter5Point.Contains(ch.ToString())) points += 5;
           if (letter8Point.Contains(ch.ToString())) points += 8;
           if (letter10Point.Contains(ch.ToString())) points += 10;
        }
       return points;
    }
}