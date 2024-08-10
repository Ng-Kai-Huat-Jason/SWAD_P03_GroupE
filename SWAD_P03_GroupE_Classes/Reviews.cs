using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAD_P03_GroupE_Classes
{
    public class Reviews
    {
        string ReviewID { get; set; }
        int StarInt { get; set; }
        string ReviewDesc { get; set; }

        public Reviews(){}

        public Reviews(string reviewID, int starInt, string reviewDesc)
        {
            ReviewID = reviewID;
            StarInt = starInt;
            ReviewDesc = reviewDesc;
        }
    }
}
