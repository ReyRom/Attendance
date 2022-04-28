using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendancePC.Models
{
    public class AttendRepresentation
    {
        public string AttendChar { get; set; }
        public string Comment { get; set; }
        public bool? IsReasonable { get; set; }
        public int? IdLesson { get; set; }
        public int? IdStudent { get; set; }
        public AttendRepresentation()
        {
            AttendChar = ""; 
            Comment = ""; 
            IdLesson = null; 
            IdStudent = null;
            IsReasonable = null;
        }
        public override string ToString()
        {
            return AttendChar;
        }
    }
}
