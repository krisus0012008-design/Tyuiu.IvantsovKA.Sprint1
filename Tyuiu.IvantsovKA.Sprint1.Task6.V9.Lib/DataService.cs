using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.IvantsovKA.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            
            foreach (string word in value.Split(' '))
            {
                if (word.Length > 1)
                {
                    
                    string newWord = word[word.Length - 1] + word.Substring(0, word.Length - 1);

                    value = value.Replace(word, newWord);
                }
            }

            return value;
        }
    }
}
