using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    /// <summary>
    /// array of all words from file where name is given in constructor DONE
    /// getWords() == return all sorted words
    /// getuniquewordscount() == object of class WordsCount() return pair of unique word amount word_amount 
    /// Class WordCount = static methods sorting arrys based on appear od given word
    /// </summary>
    
    class SortedWordsFromFiles
    {
        private string[] words;

        public SortedWordsFromFiles(string file)
        {
            //For now we accustom that the words will be seperated by white space
            words = file.Split(' ');
            foreach (var item in words)
            {
                //Console.WriteLine(item);
            }
        }

        //Sort array alpha ASC
        public void getWords()
        {
            var local = words;

            for (int i = 0; i < words.Length; i++)
            {
                //Sort(local,i,words.Length - i);
                for(int y = i;y<words.Length;y++)
                {
                    Sort(local, y, words.Length - y - 1 );
                }
            }

            foreach (var item in local)
            {
                Console.WriteLine(item);
            }
        }


        private void Sort(string[] wordsLocal, int firstElement, int secondElement)
        {
            var c = wordsLocal[firstElement]; var d = wordsLocal[secondElement];
            var y = char.Parse(wordsLocal[firstElement].ElementAt(0).ToString());
            var z = char.Parse(wordsLocal[secondElement].ElementAt(0).ToString());
            if (char.Parse(wordsLocal[firstElement].ElementAt(0).ToString()) < char.Parse(wordsLocal[secondElement].ElementAt(0).ToString()))
            {
                var temp = wordsLocal[firstElement];
                wordsLocal[firstElement] = wordsLocal[secondElement];
                wordsLocal[secondElement] = temp;
            }
        }
    }
}
