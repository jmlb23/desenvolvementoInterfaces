using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace post.Modelo.entidades
{

    public struct Date
    {
        DateTime data_a_gardar;

        public Date(DateTime data)
        {
            data_a_gardar = data;
        }

        public static Date today()
        {
            return new Date(DateTime.Today);
        }

        public override string ToString()
        {
            return data_a_gardar.ToString();
        }

        public static bool operator >(Date d1, Date d2)
        {
            return d1.data_a_gardar > d2.data_a_gardar;
        }

        public static bool operator <(Date d1, Date d2)
        {
            return d1.data_a_gardar < d2.data_a_gardar;
        }

        public static bool operator ==(Date d1, Date d2)
        {
            return d1.data_a_gardar == d2.data_a_gardar;
        }

        public static bool operator !=(Date d1, Date d2)
        {
            return d1.data_a_gardar != d2.data_a_gardar;
        }
    }
}
