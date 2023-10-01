using System;
using System.Linq;

namespace java.lang
{
    public class String : Object
    {
        private readonly string _value;

        public String(string d) {
            this._value = d;
        }

        public String(String d)
        {
            this._value = d.ToString();
        }

        public String(byte[] charBytes)
        {
            var chars = new char[charBytes.Length];
            for (var i = 0; i < charBytes.Length; i++)
                chars[i] = (char)charBytes[i];

            this._value = new string(chars);
        }

        public String trim()
        {
            return _value.Trim();
        }

        public bool startsWith(String str)
        {
            return _value.StartsWith(str.ToString());
        }

        public static implicit operator String(string d)
        {
            return new String(d);
        }

        public static implicit operator string(String d)
        {
            return d._value;
        }

        public static String operator +(String s1, String s2)
        {
            string ss1 = (s1 == null) ? "" : s1.ToString();
            string ss2 = (s2 == null) ? "" : s2.ToString();
            return ss1 + ss2;
        }
        public static String operator +(String s1, object s2)
        {
            string ss1 = (s1 == null) ? "" : s1.ToString();
            string ss2 = (s2 == null) ? "" : s2.ToString();
            return ss1 + ss2;
        }

        public override string ToString()
        {
            return _value;
        }

        public int indexOf(String toReplace)
        {
            return _value.IndexOf(toReplace.ToString(), StringComparison.Ordinal);
        }

        public int indexOf(char p, int charPos)
        {
            return _value.IndexOf(p, charPos);
        }

        public int charAt(int it)
        {
            return _value[it];
        }

        public String subString(int startIndex, int endIndex)
        {
            var length = endIndex - startIndex;
            return _value.Substring(startIndex, length);
        }

        public String subString(int p)
        {
            return _value.Substring(p);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is String)) return false;
            var str = (String) obj;
            return this._value.Equals(str._value);
        }

        public String[] split(string p)
        {
            return _value.Split(new[] { p }, StringSplitOptions.None)
                .Select(x => new String(x))
                .ToArray();
        }

        public int length()
        {
            return _value.Length;
        }

        public bool equalsIgnoreCase(string p)
        {
            return this._value.Equals(p, StringComparison.OrdinalIgnoreCase);
        }

        public String[] split(char p)
        {
            return this._value.Split(p)
                .Select(x => new String(x))
                .ToArray();
        }
    }
}
