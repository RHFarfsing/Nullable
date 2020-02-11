using System;

namespace Nullable {
    class Program {
        static void Main(string[] args) {
            var abe = new Student {Id = 1, Name = "Abe", SAT = null, GPA = 3, Major=accounting
            };
            var brian = new Student {Id = 2, Name = "Brian", SAT = 1200, GPA = 2.5, Major=null
            };
            var carol = new Student {Id = 3, Name = "Carol", SAT = null, GPA = 4.5, Major=engineering
            };
            var dave = new Student {Id = 4, Name = "Dave", SAT = 1400, GPA = 3.5, Major=business
            };
            var accounting = new Major {Id = 100, Description = "Accounting", MinSat = 1000
            };
            var business= new Major {Id = 200, Description = "Business", MinSat = 1200
            };
            var engineering = new Major {Id = 300, Description = "Engineering",MinSat = 1400
            };

        }
    }
}
