using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class WebDbContext
    {
        private static KaoshiDBEntities _kaoshiDBEntities = null;

        public static KaoshiDBEntities KaoshiDBEntities
        {
            get
            {
                if (_kaoshiDBEntities == null)
                {
                    _kaoshiDBEntities = new KaoshiDBEntities();
                }
                return _kaoshiDBEntities;
            }
        }
    }
}
