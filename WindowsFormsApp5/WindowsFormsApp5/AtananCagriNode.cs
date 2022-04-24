using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class AtananCagriNode
    {
        public string CevaplananCagriid { get; set; }
        public string cevaplayanMTemsilcisi { get; set; }
        public string baslamaZamani { get; set; }
        public string bitisZamani { get; set; }
        public string notlar { get; set; }
        public AtananCagriNode next { get; set; }
        public AtananCagriNode( string temsilci, string musteriTC, string baslangiczmn, string bitiszmn, string not)
        {
            this.cevaplayanMTemsilcisi = temsilci;
            this.baslamaZamani = baslangiczmn;
            this.bitisZamani =bitiszmn;
            this.notlar = not;         
            this.next = null;
        }

    }
}
