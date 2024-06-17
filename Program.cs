using System.Text;

namespace CSharp3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4
            //string[] words = { "Apple", "Banana", "Orange", "Pear", "Mango", "Lemon" };
            //int chosenLength = 6;

            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (words[i].Length == chosenLength)
            //    {
            //        words[i] = words[i].Substring(0, words[i].Length - 3) + "$$$";
            //    }
            //}

            //foreach (var word in words)
            //{
            //    Console.WriteLine(word);
            //}

            //5
            //string text = "Find the word at the specified position in the text and print its first letter. The position is provided by the user.";

            //Console.Write("Enter the word number: ");
            //int wordNumber;

            //while (!int.TryParse(Console.ReadLine(), out wordNumber) || wordNumber <= 0)
            //{
            //    Console.Write("Please enter a correct word number: ");
            //}

            //string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //if (wordNumber <= words.Length)
            //{
            //    string word = words[wordNumber - 1];
            //    char firstLetter = word[0];
            //    Console.WriteLine(firstLetter);
            //}
            //else
            //{
            //    Console.WriteLine("The word number is out of the range of the text.");
            //}

            //6
            //string input = "  This   is  an example  text  ";

            //string trimmedInput = input.Trim();

            //string[] words = trimmedInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //string result = string.Join("*", words);

            //Console.WriteLine(result);

            //7
            StringBuilder result = new StringBuilder();

            while (true)
            {
                Console.Write("Enter a word (end with a word containing a period): ");
                string word = Console.ReadLine();

                if (result.Length > 0)
                {
                    result.Append(", ");
                }
                result.Append(word);

                if (word.EndsWith('.'))
                {
                    break;
                }
            }

            Console.WriteLine("Resulting string:");
            Console.WriteLine(result.ToString());

        }
    }
}
