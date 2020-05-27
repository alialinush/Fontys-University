using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOverview
{
    class peoplecheckedin
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public peoplecheckedin(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;

        }

    }
}
