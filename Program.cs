class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter the coordinates and dimensions of the first announcement:");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int w1 = int.Parse(Console.ReadLine());
            int h1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the coordinates and dimensions of the second announcement:");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int w2 = int.Parse(Console.ReadLine());
            int h2 = int.Parse(Console.ReadLine());

            int overlapX1 = Math.Max(x1 - w1 / 2, x2 - w2 / 2);
            int overlapY1 = Math.Max(y1 - h1 / 2, y2 - h2 / 2);
            int overlapX2 = Math.Min(x1 + w1 / 2, x2 + w2 / 2);
            int overlapY2 = Math.Min(y1 + h1 / 2, y2 + h2 / 2);

            int overlapWidth = overlapX2 - overlapX1;
            int overlapHeight = overlapY2 - overlapY1;

            int overlapArea = Math.Max(0, overlapWidth * overlapHeight);

            if (overlapArea > 8)
            {
                Console.WriteLine("Too Much Overlapping");
            }
            else if (overlapArea > 0)
            {
                Console.WriteLine("Not Much Overlapping");
            }
            else
            {
                Console.WriteLine("No Overlapping");
            }
    }
}