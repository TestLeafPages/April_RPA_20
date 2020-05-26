using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprLearnCSharp // Package or subFolder of project
{
    class LearnStrings
    //NameSpace - > using /   import(java) -> package
        //Class - > Car
            //methods
            //variable - > info about the class -> model,color,no of seats
    {
        static void Main(string[] args) // -> main Method   -> Main.xaml
        {
            
            // dataType nameOfVariable = value;
            string text1 = " Learn RPA is Fun ";
            string text2 = "RPA";// ascii -> a -> 65
            string[] allWords = text1.Split(' ');
            Console.WriteLine(allWords.Length);
            string joinedText = string.Join("",allWords);
            /*Console.WriteLine(joinedText.ToLower());
            Console.WriteLine(joinedText.ToUpper());*/
            Console.WriteLine(text1.Replace("[a-z]", "CSharp"));
            Console.WriteLine(text1.Insert(0, "The "));
            















            /*foreach(string eachItem in allWords)
            {
                Console.WriteLine(eachItem);
            }*/
            // if (text1.Equals(text2))
            //(text1.Equals(text2,StringComparison.InvariantCultureIgnoreCase))
            /* if(text1.Contains(text2))
             {
                 Console.WriteLine("Matching");
             }
             else
             {
                 Console.WriteLine("not Matching");
             }*/
















            // int charCount = text.Length;
            //className objectName = new className(); get Access for the class
            //objectName.methodName();
            //ClassName.Method - > Static Way
            // Console.WriteLine(charCount);
            /*for(int i=0; i < text.Length; i++)
            {
                Console.Write(text[i]);
            }
            Console.WriteLine();*/





        }
    }
}
