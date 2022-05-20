using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArknightsWiki.Arknights
{
    internal class Operator
    {
        public string oprName { get; }
        public string oprRace { get; }
        public string[] oprTags { get; }
        public string[] oprSkills { get; }
        public string oprImagePath { get; }

        public Operator(string oprName, string oprRace, string oprTags, string oprSkills, string oprImagePath)
        {
            this.oprName = oprName;
            this.oprRace = oprRace;
            this.oprTags = oprTags.Split(',');
            this.oprSkills = oprSkills.Split(',');
            this.oprImagePath = oprImagePath;
        }

        public override string ToString()
        {
            return "(\'" + oprName + "\'" + ","
               + "\'" + oprRace + "'" + ","
               + "\'" + string.Join(",", oprTags) + "\'" + ","
               + "\'" + string.Join(",", oprSkills) + "\'" + ","
               + "\'" + oprImagePath + "\')";
        }
    }
}
