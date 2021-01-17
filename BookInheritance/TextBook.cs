using System;
using System.Collections.Generic;
using System.Text;

namespace BookInheritance
{
    class TextBook : Book
    {
        public int GradeLevel { get; set; }
        public override double Price
        {
            get { return base.Price; }
            set
            {
                if (value >= 20 && value <= 80)
                    base.Price = value;
            }
        }
    }
}
