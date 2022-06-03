using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArknightsWiki.Arknights
{
    internal class Drops
    {
        public string matName { get; set; }
        public string oprID { get; set; }
        public string sampleSize { get; set; }
        public string dropSize { get; set; }
        public string probability { get; set; }
        public string cost { get; set; }

        public Drops(string matName, string oprID, string ss, string ds, string p, string c)
        {
            this.matName = matName;
            this.oprID = oprID;
            this.sampleSize = ss;
            this.dropSize = ds;
            this.probability = p;
            this.cost = c;
        }
    }
}
