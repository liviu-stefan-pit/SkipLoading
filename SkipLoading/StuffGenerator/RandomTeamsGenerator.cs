using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuffGenerator
{
    public class RandomTeamsGenerator
    {
        public static Random random = new Random();

        public static void GenerateGames(int nrOfGames = 100)
        {
            for (int i = 0; i < nrOfGames; i++)
            {
                long t1 = random.NextInt64(1, 10);
                long t2 = random.NextInt64(1, 10);

                if (t1 == t2) continue;

                File.AppendAllText("myGames.txt", $"Team{t1} : {random.NextInt64(1, 3)}-{random.NextInt64(1, 3)} : Team{t2}\n");
            }
        }
    }
}
