using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class FrequencyOfWord
    {
        public void count_freq(String str)
        {
            SortedDictionary<String,
                             int> mp = new SortedDictionary<String,
                                                            int>();

            // Splitting to find the word
            String[] arr = str.Split(' ');

            // Loop to iterate over the words
            for (int i = 0; i < arr.Length; i++)
            {

                // Condition to check if the
                // array element is present
                // the hash-map
                if (mp.ContainsKey(arr[i]))
                {
                    mp[arr[i]] = mp[arr[i]] + 1;
                }
                else
                {
                    mp.Add(arr[i], 1);
                }
            }

            // Loop to iterate over the
            // elements of the map
            foreach (KeyValuePair<String, int> entry in mp)
            {
                Console.WriteLine(entry.Key + " - " +
                                  entry.Value);
            }
        }
    }
}
