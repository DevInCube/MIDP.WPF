using java.lang;
using System.Collections.Generic;

namespace java.csharp
{
    public static class Extensions
    {

        private static readonly Dictionary<object, Class> Classes = new Dictionary<object, Class>();

        public static Class getClass(this object obj)
        {
            if (!Classes.ContainsKey(obj))
            {
                Classes.Add(obj, new Class());
            }
            return Classes[obj];
        }
    }
}
