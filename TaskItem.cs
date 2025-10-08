using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_List
{
    public class TaskItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string TitleColor { get; set; }
        public string DescriptionColor { get; set; }
        public bool Completed { get; set; }

    }
}
