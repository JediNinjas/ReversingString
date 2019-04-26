// James Prochaska
// 2.15.18
// This program allows the user to type out a sentence and then reverses 
// the sentence that they inputed, character by character.

using System;

namespace Task1_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // The variables created to store sentence, reverse_Sentence, and sentence_length data.
            string sentence = ""; 
            string reverse_Sentence = "";
            int sentence_Length;

            // I am asking the user to enter a sentence of their choosing.
            Console.Write("Type out a sentence then press enter: "); 
                sentence = Console.ReadLine();

            // The length is used to store how long the sentence is. We subtract by one 
            // because the sentence memory index starts at 0 instead of 1.
            sentence_Length = sentence.Length - 1; 

            // This while loop is reversing the string based on the length of the sentence 
            // and storing it into the variable reverse_Sentence. It starts at the end and works its 
            // way backwards.
            while (sentence_Length >= 0)                                                    
            {
                reverse_Sentence = reverse_Sentence + sentence[sentence_Length];
                sentence_Length--;
            }

            // Printing the reverse sentence
            Console.WriteLine("\nHere is your sentence in reverse: "+ reverse_Sentence);
        }
    }
}
