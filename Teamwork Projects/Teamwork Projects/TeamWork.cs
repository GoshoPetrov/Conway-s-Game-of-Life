using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Teamwork_Projects
{
    internal class TeamWork
    {
        public string Creator { get; set; }

        public string TeamName { get; set; }

        public List<string> Users { get; set; } = new List<string>();
    }
}
