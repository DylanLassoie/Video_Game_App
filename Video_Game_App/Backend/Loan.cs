using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Game_App.Backend
{
    internal class Loan
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public bool ongoing { get; set; }
        public string lender { get; set; }
        public string borrower { get; set; }
        public string propriétaire { get; set; }
        public string jeux { get; set; }
    }
}
