using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArknightsWiki.Arknights
{
    internal class Materail
    {
        public string matName { get; }
        public string matIcon { get; }
        public string matAccess { get; }

        public Materail(string matName, string matIcon, string matAccess)
        {
            this.matName = matName;
            this.matIcon = matIcon;
            this.matAccess = matAccess;
        }

        public override string ToString()
        {
            return "(\'" + matName + "\'" + ", "
               + "\'" + matIcon + "'" + ", "
               + "\'" + matAccess + "\')";
        }
    }
}
