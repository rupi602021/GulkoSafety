using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GulkoSafety.Models
{
    public class defect_type
    {
        int defect_type_num;
        string type_name;

        public defect_type(int defect_type_num, string type_name)
        {
            Defect_type_num = defect_type_num;
            Type_name = type_name;
        }

        public int Defect_type_num { get => defect_type_num; set => defect_type_num = value; }
        public string Type_name { get => type_name; set => type_name = value; }

        public defect_type() { }
    }
}