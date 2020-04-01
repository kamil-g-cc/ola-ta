using System;

namespace ola_ta
{
    public class FileContent
    {

    }
    interface IIterator
    {
        /*
            return either there is an another element on the list
        */
        public bool HasNext();
        /*
            returns the current element on the list and move to the next element
        */
        public string MoveNext();
        /*
            currently does nothing
        */
        public void Remove();
    }

    class WordIterator : IIterator
    {
        public bool HasNext()
        {
            //TODO: implement
            return false;
        }
        public string MoveNext()
        {
            //TODO: implment
            return "";
        }
        public void Remove()
        {

        }
        public WordIterator(FileContent fileContent)
        {

        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //var file_content = new FileContent();
            var moj_pierwszy_iterator = new WordIterator(new FileContent());
            Console.WriteLine("Bye, bye!");
        }
    }
}
