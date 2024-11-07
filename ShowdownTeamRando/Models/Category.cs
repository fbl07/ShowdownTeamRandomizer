using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowdownTeamRando.Models
{
    public class Category
    {
        public virtual string Name { get; set; }
        public virtual List<Team> Teams { get; set; }

    }
}
