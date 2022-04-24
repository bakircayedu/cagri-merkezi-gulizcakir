using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class CagriMerkezi
    {
        public string CagriMerName { get; set; }
        public CagriMerkezi(MusteriTemsilcisi mt1 ,MusteriTemsilcisi mt2, MusteriTemsilcisi mt3, MusteriTemsilcisi mt4,string name)
        {
            this.CagriMerName = name;
        }
    }
}
