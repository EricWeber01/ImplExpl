using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplExpl
{
    internal class Date
    {
        class data
        {
            DateTime dat = new DateTime();
            DateTime da()
            {
                return dat;
            }
            public data() { }
            data(int d)
            {
                dat = dat.AddDays(d);
            }
            public data(int d, int m, int g)
            {
                dat = dat.AddYears(g);
                dat = dat.AddMonths(m);
                dat = dat.AddDays(d);
            }
            public static data operator ++(data p1)
            {
                return new data(p1.dat.Day, p1.dat.Month - 1, p1.dat.Year - 1);
            }
            public static data operator --(data p1)
            {
                return new data(p1.dat.Day - 2, p1.dat.Month - 1, p1.dat.Year - 1);
            }
            public static bool operator ==(data p1, data p2)
            {
                if (p1.dat.Date == p2.dat.Date)
                {
                    Console.WriteLine("\nДаты равны\n");
                    return true;
                }
                else
                {
                    Console.WriteLine("\nДаты не равны\n");
                    return false;
                }
            }
            public static bool operator !=(data p1, data p2)
            {
                if (p1.dat.Date != p2.dat.Date)
                {
                    Console.WriteLine("\nДаты не равны\n");
                    return true;
                }
                else
                {
                    Console.WriteLine("\nДаты равны\n");
                    return false;
                }
            }
            public static bool operator >(data p1, data p2)
            {
                if (p1.dat.Date > p2.dat.Date)
                {
                    Console.WriteLine("\nЛевая дата больше\n");
                    return true;
                }
                else
                {
                    Console.WriteLine("\nПравая дата больше\n");
                    return false;
                }
            }
            public static bool operator <(data p1, data p2)
            {
                if (p1.dat.Date < p2.dat.Date)
                {
                    Console.WriteLine("\nПравая дата больше\n");
                    return true;
                }
                else
                {
                    Console.WriteLine("\nЛевая дата больше\n");
                    return false;
                }
            }
            public static implicit operator data(int _s)
            {
                return new data(_s);
            }
            public static explicit operator int(data da)
            {

                return (int)(da.dat.Ticks / 864000000000);
            }
            public override string ToString()
            {
                return dat.ToShortDateString();
            }
            public override bool Equals(object obj)
            {
                return obj is data data &&
                       dat == data.dat;
            }
            public override int GetHashCode()
            {
                return -1767593866 + dat.GetHashCode();
            }
        }
    }
}
