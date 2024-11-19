using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook.Models
{
    public class Group_s
    {
        public int Id { get; set; }
        public string GroupName { get; set; }

        public override string ToString()
        {
            return GroupName; // This will be displayed in the ListBox
        }
    }
}
