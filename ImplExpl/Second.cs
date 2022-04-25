using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplExpl
{
    class Second
    {
        public int sec { get; set; }
        public Seconds(int _s) { sec = _s; }
        public static implicit operator Seconds(int _s)
        {
            return new Seconds(_s);
        }
        public static explicit operator int(Seconds _s)
        {
            return _s.sec;
        }
        public override string ToString()
        {
            return $"{sec} seconds.";
        }
    }
}
