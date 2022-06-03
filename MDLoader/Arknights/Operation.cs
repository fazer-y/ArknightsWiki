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
        public string eneAmount { get; }
        public string goal { get; }
        public string oprMapPath { get; }
        public string cost { get; }

        public Operation(string oprID, string oprName, string eneAmount, string goal, string oprMapPath, string cost)
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
