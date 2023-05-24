var pq = new PriorityQueue<int, int>(new List<(int, int)>{ (6, 6), (1, 1), (2, 2), (3, 3), (4, 4), (5, 5) });
var pq2 = new PriorityQueue<int, int>(new List<(int, int)>{ (6, -6), (1, -1), (2, -2), (3, -3), (4, -4), (5, -5) });

Console.WriteLine("PriorityQuque 1 - Ascending / Min Heap");
while (pq.Count > 0)
{
    var v = pq.Dequeue();
    Console.WriteLine($"Value: {v}");
}

Console.WriteLine("PriorityQuque 2 - Descending / Max Heap");
while (pq2.Count > 0)
{
    var v = pq2.Dequeue();
    Console.WriteLine($"Value: {v}");
}
