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
        private string[] wyrazy = {"kamil", "ola", "wyraz", "kolejny"};
        private int current_wyraz = 0;
        private int last_wyraz = 4;
        public bool HasNext()
        {
            if(current_wyraz<last_wyraz) return true;
            return false;
        }
        public string MoveNext()
        {
            if(current_wyraz>last_wyraz) return "";
            return wyrazy[current_wyraz++];
            
        }
        public void Remove()
        {

        }
        public WordIterator()
        {

        }
        public WordIterator(FileContent fc)
        {

        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            
            var moj_pierwszy_iterator = new WordIterator();
            
            while(moj_pierwszy_iterator.HasNext()){
                Console.WriteLine(moj_pierwszy_iterator.MoveNext());
            }
            
            Console.WriteLine("Bye, bye!");
        }
    }
}
