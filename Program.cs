namespace HashTable
{
    class Program
    {
        public static void Main(string[] args)
        {
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);//creating object and Key and value datatype is string and size is 5
            // Adding values in hashtable.
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "To");
            hash.Add("5", "be");


            // getting the specific value from hashtable.
            string hash5 = hash.Get("5");
            Console.WriteLine("5th index value:" + hash5);
            // hash.Remove("0");
            hash.Display();
            Console.Read();
        } 
    }
}
