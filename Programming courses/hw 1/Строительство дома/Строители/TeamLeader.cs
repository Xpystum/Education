using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Строительство_дома.Дом;

namespace Строительство_дома.Строители
{
    internal class TeamLeader : Worker
    {

       public Dictionary<Worker, StringBuilder> InfoBuild { get; set; } = new Dictionary<Worker, StringBuilder>();

      //public string? Report { get;private set; }

        public TeamLeader(string? fIO, string? name_firm, bool statusWork = false) : base(fIO, name_firm, statusWork) { }
        public new string jobs(House house)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in InfoBuild)
            {
                sb.Append(item.Value);
            }
            return sb.ToString();
        }


    }
}
