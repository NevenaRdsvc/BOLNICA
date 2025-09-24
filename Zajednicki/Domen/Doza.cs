using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    using System.ComponentModel;

    public enum Doza
    {
        [Description("Jednom dnevno 1x1")]
        JednomDnevno_1x1 = 1,

        [Description("Dva puta dnevno 2x1")]
        DvaPutaDnevno_2x1 = 2,

        [Description("Dva puta dnevno 2x2")]
        DvaPutaDnevno_2x2 = 3,

        [Description("Tri puta dnevno 3x1")]
        TriPutaDnevno_3x1 = 4,

        [Description("Tri puta dnevno 3x2")]
        TriPutaDnevno_3x2 = 5,

        [Description("Četiri puta dnevno 4x1")]
        CetiriPutaDnevno_4x1 = 6,

        [Description("Po potrebi")]
        PoPotrebi = 7
    }

}
