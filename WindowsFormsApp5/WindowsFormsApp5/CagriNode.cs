using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class CagriNode
    {
        public int CagriId { get; set; } = 1;
        public string musteriTur{ get; set; }
        public int musteriId { get; set; } = 1;
        public CagriNode next { get; set; }
        public CagriNode(string tur)
        {

            this.musteriTur = tur;
            this.next = null;
        }

    }
}
