namespace HashTable
{
    class Program
    {
        public static void Main(string[] args)
        {
            MyMapNode<string, int> hash = new MyMapNode<string, int>(5);

            //creating a string of long sentence
            string words = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            //adding values into array
            string[] arr = words.Split(' ');

            //creating a linkedlist to check for duplicates value
            LinkedList<string> checkForDuplication = new LinkedList<string>();

            //iterating loop over the array of sentence words
            foreach (string element in arr)
            {
                int count = 0;
                //another foreach loop to check if other same element is present
                //if present counter is incremented
                foreach (string match in arr)
                {
                    if (element == match)
                    {
                        count++;
                        //if same element is coming in 2nd time, it will be presnent in linkedlist, so loopwill break and no further counting will be done
                        if (checkForDuplication.Contains(element))
                        {
                            break;
                        }
                    }

                }
                //if element is already there in list, outer loop will be continued and loop will shift to next value
                //basically only values appearing for 1st time, will be added in linkedlist and added in hash table, so that frequency can be displayed.
                if (checkForDuplication.Contains(element))
                {
                    continue;
                }
                //added element in linkedlist
                checkForDuplication.AddLast(element);
                //added element and it's frequency in hashtable.
                hash.Add(element, count);
            }
            //getting the specific value from hashtable.
            int frequency = hash.Get("avoidable");
            Console.WriteLine("frequency for avoidable:\t" + frequency);

            //Displaying all the elements from the linkedlist
            Console.WriteLine();
            Console.WriteLine("Displaying all the key value pairs in hash table");
            hash.Display();

            Console.WriteLine("**********************************************");

            //removing avoidable word from the hashtable
            hash.Remove("avoidable");
            Console.WriteLine("Word removed from hashtable");
            //getting the specific value from hashtable.
            int removedWordFrequency = hash.Get("avoidable");
            Console.WriteLine("frequency for avoidable:\t" + removedWordFrequency);
            //Displaying all the elements from the linkedlist
            Console.WriteLine();
            Console.WriteLine("Displaying all the key value pairs in hash table");
            hash.Display();


            Console.Read();
            hash.Add(a, element);
            a++;

        }

        int index = 18;
        string choice = hash.Get(index);  // getting the specific value from hashtable.
        Console.WriteLine("{0}th index values : is {1}", index, choice);

int index2 = 15;
        string choice2 = hash.Get(index2);
        Console.WriteLine("{0}th index values : is {1}", index2, choice2);

hash.Remove(index);//remove 18 index
hash.Display();
Console.Read();





        }
}
