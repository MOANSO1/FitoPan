using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Utilities{

        public String getRandomUUID()
        {
            return Guid.NewGuid().ToString().Replace("-", "").Substring(0,6);
        }
    }
}
