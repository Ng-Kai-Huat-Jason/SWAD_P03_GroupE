using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAD_P03_GroupE_Classes
{
    public class Reviews
    {
        string reviewID { get; set; }
        int starInt { get; set; }
        string reviewDesc { get; set; }

        public Reviews()
        {
        }

        public Reviews(string ReviewID, int StarInt, string ReviewDesc)
        {
            reviewID = ReviewID;
            starInt = StarInt;
            reviewDesc = ReviewDesc;
        }
    }
}
