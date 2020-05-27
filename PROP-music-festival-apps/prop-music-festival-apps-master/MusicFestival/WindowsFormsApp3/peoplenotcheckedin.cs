using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOverview
{
    class peoplenotcheckedin
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public peoplenotcheckedin(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;

        }

    }
}
