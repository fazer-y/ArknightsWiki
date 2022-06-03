using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArknightsWiki.Arknights
{
    internal class Enemies
    {
        public string eneName { get; }
        public string eneIcon { get; }
        public string eneAttack { get; }
        public string[] eneAttributes { get; }
        public string eneFeature { get; }

        public Enemies(string eneName, string eneIcon, string eneAttack, string eneAttributes, string eneFeature)
        {
            this.eneName = eneName;
            this.eneIcon = eneIcon;
            this.eneAttack = eneAttack;
            this.eneAttributes = eneAttributes.Split(',');
            this.eneFeature = eneFeature;
        }

        public override string ToString()
        {
            return "(\'" + eneName + "\'" + ","
               + "\'" + eneIcon + "'" + ","
               + "\'" + eneAttack + "\'" + ","
               + "\'" + string.Join(",", eneAttributes) + "\'" + ","
               + "\'" + eneFeature + "\')";
        }
    }
}
