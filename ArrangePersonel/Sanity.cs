using System;
using System.Collections.Generic;
using System.Text;

namespace ArrangePersonel
{
    static class Sanity
    {
        public static void Requires(bool b, string message)
        {
            if (!b)
                throw new Exception(message);
        }

        public static void Requires(bool b)
        {
            if (!b)
                throw new Exception();
        }
    }
}
