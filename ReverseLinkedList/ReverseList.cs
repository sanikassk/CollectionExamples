namespace ReverseLinkedList
{
    internal class ReverseList
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("sanika");
            list.AddLast("raj");
            list.AddAfter(list.First, "suryakant");
            list.AddBefore(list.Last, "suchita");


            var rev = list.Reverse();
            foreach (string s in rev)
            {
                Console.WriteLine(s);
            }



        }
    }

}
