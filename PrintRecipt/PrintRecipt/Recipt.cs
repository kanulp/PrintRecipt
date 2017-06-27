using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintRecipt
{
    public class Recipt
    {
        //for team member 1
        public int ID { get; set; }
        public string Team_Member_Name_1 { get; set; }
        public int Team_Member_Phone_1 { get; set; }
        public string Team_Member_1_Branch { get; set; }
        public string Team_Member_1_Batch { get; set; }
        public int Team_Member_1_Year { get; set; }
        public string Team_Member_1_department { get; set; }
        public string Team_Member1_College { get; set; }
//for team member 2
        public string Team_Member_Name_2 { get; set; }
        public int Team_Member_Phone_2 { get; set; }
        public string Team_Member_2_Branch { get; set; }
        public string Team_Member_2_Batch { get; set; }
        public int Team_Member_2_Year { get; set; }
        public string Team_Member_2_department { get; set; }
        public string Team_Member_2_College { get; set; }


        public int Price{get;set;}
        public int Quantity { get; set; }
        public string Total{ get { return string.Format("Rs(0)", Price*Quantity); } }

    }
}
