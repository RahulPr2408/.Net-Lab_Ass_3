using System;

namespace Code_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // find length of a String
            Console.Write("Enter a string to find Length : ");
            String str1 = Console.ReadLine();

            int length = str1.Length;
            Console.WriteLine($"The length of {str1} = {length}");

            // check sentences
            String str2; 
            Console.Write("Enter a Sentence : ");
            str2 = Console.ReadLine();
            checkSentence(str2);

            // full name
            String str3;
            Console.Write("Enter Your Full name (without Middle name) : ");
            str3 = Console.ReadLine();
            FullName(str3);
        }

        public static void checkSentence(String str) {
            if(str.EndsWith(".")) {
                Console.WriteLine("The sentence is Declarative");
            }
            else if (str.EndsWith("?")) {
                Console.WriteLine("The sentence is Interogatory");
            }
            else if (str.EndsWith("!")) {
                Console.WriteLine("The sentence is Exclaimatory");
            } 
            else {
                Console.WriteLine("This is not a sentence ");
            }
        }

        public static void FullName(String str) {
            int index = str.IndexOf(" ");

            String firstName = str.Substring(0,index);
            String lastName = str.Substring(index);

            Console.WriteLine($"{lastName} , {firstName}");
        } 
    }
}
