namespace Rectangle_Intersection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            Dictionary<string, Rectangle> rectanglesById = new Dictionary<string, Rectangle>();
            for(int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                string id = command[0];
                int width = int.Parse(command[1]);
                int height = int.Parse(command[2]);
                int left = int.Parse(command[3]);
                int top = int.Parse(command[4]);

                Rectangle rect = new Rectangle(id, width, height, top, left);
                rectanglesById.Add(rect.Id, rect);
            }

            for(int j = 0; j < m; j++)
            {
                string[] ids = Console.ReadLine().Split();
                string id1 = ids[0];
                string id2 = ids[1];

                Rectangle r1 = null, r2 = null;

                r1 = rectanglesById[id1];
                r2 = rectanglesById[id2];

                Console.WriteLine(r2.Intersect(r1));
            }
        }
    }
}