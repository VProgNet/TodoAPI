using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoAPI.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }

        public List<TodoItem> toList()
        {
            List<TodoItem> lst = new List<TodoItem>();
            lst.Add(this);
            //lst.Append(this);
            return lst;
        }
        /*public override string ToString() => Name;*/
    }
}
