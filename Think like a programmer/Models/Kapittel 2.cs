namespace Think_like_a_programmer.Models
{
    internal class Kapittel_2
    {
        private List<List<int>> Oppgave1 = new List<List<int>>() {
            new List<int>() { 8 },
            new List<int>() { 0, 1, 6 },
            new List<int>() { 0, 2, 4 },
            new List<int>() { 0, 3, 2 },
        };

        private List<List<int>> Oppgave2 = new List<List<int>>() {
            new List<int>() { 0, 3, 2 },
            new List<int>() { 0, 2, 4 },
            new List<int>() { 0, 1, 6 },
            new List<int>() { 8 },
            new List<int>() { 0, 1, 6 },
            new List<int>() { 0, 2, 4 },
            new List<int>() { 0, 3, 2 },
        };

        private List<List<int>> Oppgave3 = new List<List<int>>() {
            new List<int>() { 1, 12, 1 },
            new List<int>() { 0, 1, 2, 8, 1, 2 },
            new List<int>() { 0, 2, 3, 4, 3 },
            new List<int>() { 0, 3, 8 },
            new List<int>() { 0, 3, 8 },
            new List<int>() { 0, 2, 3, 4, 3 },
            new List<int>() { 0, 1, 2, 8, 1, 2 },
            new List<int>() { 1, 12, 1 },
        };


        public void SelectShape()
        {
            PrintShape(Oppgave1);

            Console.WriteLine();

            PrintShape(Oppgave2);

            Console.WriteLine();

            PrintShape(Oppgave3);

        }

        private void PrintShape(List<List<int>> Oppgave)
        {
            foreach (var list in Oppgave)
            {
                PrintLine(list);
            }
        }

        private void PrintLine(List<int> list)
        {
            for (var i = 0; i < list.Count; i++)
            {
                if (i % 2 == 0)
                {
                    for (var j = 0; j < list[i]; j++) Console.Write("#");
                }
                else
                {
                    for (var j = 0; j < list[i]; j++) Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
