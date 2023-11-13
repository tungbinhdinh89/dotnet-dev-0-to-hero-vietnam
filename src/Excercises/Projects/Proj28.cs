namespace Exercises.Items
{
    public class Proj28 : BaseProj
    {
        public override string Description => " Write a C# program to reverse the words of a sentence.";

        public override void Run()
        {
           var originalSentence = GetString("Input your sentence: ");

            Console.WriteLine($"Original Sentence: {originalSentence}");
            Console.WriteLine($"Reverse Sentence: {ReverseSentence(originalSentence)}");
        }

        static string GetString(string msg)
        {
            Console.WriteLine(msg);
            string str = Console.ReadLine();
            return str;
        }

        static string ReverseSentence(string sentence)
        {
            string result = "";
            string reverseSentece = "";
            List <string> wordlist = new List<string>();
            string[] word = sentence.Split(new[] {" "},StringSplitOptions.None);

            for(int i = word.Length -1; i >= 0; i--)
            {
                result += word[i] + " ";
            }
            wordlist.Add(result);
            foreach(string word2 in wordlist)
            {
                reverseSentece = word2 + "";
            }
            return reverseSentece;
        }
    }
}
