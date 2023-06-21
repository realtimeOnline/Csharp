using System;

class CharCountusingDict
{

    public static Dictionary<string, int> charCount(string Input)
    {

        Char[] c = Input.ToCharArray();

        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        String temp = String.Empty;

        for (int i = 0; i < c.Length; i++)
        {
            temp += c[i];

            if (dictionary.ContainsKey(temp))
            {
                dictionary[temp] += 1;
            }
            else
            {
                dictionary.Add(temp, +1);
            }
            temp = String.Empty;
        }

        return dictionary; 

    }

    static void Main(string[] args)
    {
        Dictionary<string, int> temp =charCount("abc abc abc");
        
        foreach (KeyValuePair<string, int> charector in temp)
        {

            Console.WriteLine("The value at key {0} is {1}", charector.Key, charector.Value);
        }

    }


}