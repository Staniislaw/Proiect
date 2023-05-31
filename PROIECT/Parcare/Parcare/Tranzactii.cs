using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcare
{

    class Tranzactii
    {

        public int TransactionID { get; set; }
        //data si timpul tranzactiei
        public DateTime TimeOfTransaction { get; set; }
        //numar de inmatriculare
        public string CarID { get; set; }
        //retragerea fondurilor 
        public int TransactionAmount { get; set; }
        public Tranzactii(DateTime time, string id, int amount)
        {
            this.TransactionAmount = amount;
            this.CarID = id;
            this.TimeOfTransaction = time;
        }
    }
}
