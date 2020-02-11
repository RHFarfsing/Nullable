using System;
using System.Collections.Generic;
using System.Text;

namespace Nullable {
    public class Student {
        public int Id { get;private set; }
        public string Name { get; set; }
        public int? SAT { get; set; }
        public double GPA { get; set; }
        public Major Major { get; set; }
        //public int? MajorId { get; set; }
    }

}