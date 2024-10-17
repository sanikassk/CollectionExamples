namespace SortedDictionaryEx
{
    class SortedDictionary
    {
        public static void Main(string[] args)
        {
            SortedDictionary<int, string> sdic = new SortedDictionary<int, string>();

            sdic.Add(1, "sanika");
            sdic.Add(2, "raj");
            sdic.Add(3, "saniya");
            sdic.Add(4, "suchita");
            sdic.Add(5, "Prachi");

            PriorityQueue<int, string> pq = new PriorityQueue<int, string>();
            foreach (var item in sdic)
            {
                pq.Enqueue(item.Key, item.Value);
            }

            while (pq.Count > 0)
            {
                var res = pq.Dequeue();
                Console.WriteLine(res);
            }
        }

    }



}
