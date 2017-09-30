using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planner
{
    public class Item
    {
        public string Class { get; set; }
        public string Assignment { get; set; }
        public DateTime DueDate { get; set; }
        public string Description;
        public string Filename;

        public Item(string theClass, string assignment, string description, DateTime dueDate, string filename)
        {
            this.Class = theClass;
            this.Assignment = assignment;
            this.Description = description;
            this.DueDate = dueDate.Date;
            this.Filename = filename;
        }
    }
}
