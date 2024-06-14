namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Dictionary<string, Rectangle> rects = new Dictionary<string, Rectangle>();

            for(int i = 0; i < nm[0]; i++)
            {
                string[] command = Console.ReadLine().Split();

                string id = command[0];
                int width = int.Parse(command[1]);
                int height = int.Parse(command[2]);
                int left = int.Parse(command[3]);
                int top = int.Parse(command[4]);

                Rectangle rect = new Rectangle
                {
                    Id = id,
                    Width = width,
                    Height = height,
                    Left = left,
                    Top = top
                };

                rects.Add(id, rect);
            }

            for(int j = 0; j < nm[1]; j++)
            {
                string[] ids = Console.ReadLine().Split();

                string id1 = ids[0];
                string id2 = ids[1];

                Rectangle r1 = rects[id1];
                Rectangle r2 = rects[id2];

                Console.WriteLine(r1.Intersect(r2).ToString().ToLower());
            }
        }
    }
}