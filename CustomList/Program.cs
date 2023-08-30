namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////CustomList<string> myList = new CustomList<string>();
            ////Console.WriteLine(myList.Count);
            ////Console.WriteLine(myList.Capacity);
            ////Console.WriteLine(myList[2]);
            List<int> myExample = new List<int>();

            myExample.Add(1);
            myExample.Add(2);
            myExample.Add(3);
            myExample.Add(4);
            myExample.Add(5);
            myExample.Add(6);
            myExample.Add(7);
            myExample.Add(8);
        }
    }
}