using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBetForYou.TestingLojic
{
    public class GameObject
    {
        public string? Id => GetId();

        public string? HomeTeam { get; set; }

        public string? Score { get; set; }

        public string? AwayTeam { get; set; }

        private string GetId()
        {
            byte[] homeBytes = Encoding.ASCII.GetBytes(HomeTeam);
            byte[] awayBytes = Encoding.ASCII.GetBytes(AwayTeam);

            return $"{homeBytes.GetBytesSum() + awayBytes.GetBytesSum()}";
        }
    }
}
