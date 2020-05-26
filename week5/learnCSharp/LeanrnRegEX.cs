using System;
using System.Text.RegularExpressions;

namespace AprLearnCSharp
{
    class LeanrnRegEX
    {         //OutPut                //Input for method
              //AM returnType   MethodName(Arg)
              //no output

        static void Main(string[] args)
        {
           // LeanrnRegEX re = new LeanrnRegEX();
            reGex();
        }


            public static void reGex()
        {
            string text = "UiPath Certification 2020 and _Sarath@gmail.com more than 35000 got certified last year across globe";
            string pat = "[a-zA-Z]+[@][a-z]+[.][a-z]{3}";

            MatchCollection matchCollection = Regex.Matches(text, pat);
            foreach(Match eachMatch in matchCollection)
            {
                Console.WriteLine(eachMatch);
            }
           



            /* [abc] -> ex -> 'd' => false
             * [a-zA-Z]  -> ex -> 'e' or 'E' => true
             * [0-9] - > ex -> 5 => true
             *  \d  -> ex -> 5 => true
             *  ^[0-9] or \D ex -> '@' => true
             *  ^[abc] ex -> 'A' => true
             *  \w (only words=a-zA-Z0-9)
             *  \W (not words=a-zA-Z0-9)
             *  [ ] or \s -> ex-> ' ' => True
             *  \S ex-> ' ' => false
             *  
             *  {n}(if know the count) ->  ex ->[a-z]{3} "abc"  => true
             *  {n,m}(min-count, max-count)  ->ex ->[a-z]{3,15} "certification"  => true
             *  {n,}(min-Value, ~)  ->ex ->[a-z]{3,} "certification"  => true
             *  * -> 0 or more
             *  ? -> 0 or 1
             *  + -> 1 or more
             *  
*/        }
    }
}
