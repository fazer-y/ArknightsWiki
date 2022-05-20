using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArknightsWiki.Arknights
{
    internal class Operation
    {
        public string oprID { get; }
        public string oprName { get; }
        public int eneAmount { get; }
        public int goal { get; }
        public string oprMapPath { get; }
        public int cost { get; }

        public Operation(string oprID, string oprName, int eneAmount, int goal,
            string oprMapPath, int cost)
        {
            this.oprID = oprID;
            this.oprName = oprName;
            this.eneAmount = eneAmount;
            this.goal = goal;
            this.oprMapPath = oprMapPath;
            this.cost = cost;
        }

        public override string ToString()
        {
            return "(\'" + oprID + "\'" + ","
               + "\'" + oprName + "\'" + ","
               + eneAmount + ","
               + goal + ","
               + "\'" + oprMapPath + "\'" + ","
               + cost + ")";
        }
    }
}
