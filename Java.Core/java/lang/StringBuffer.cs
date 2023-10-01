using System.Text;

namespace java.lang
{
    public class StringBuffer 
    {

        private readonly StringBuilder _builder;

        public StringBuffer()
        {
            _builder = new StringBuilder();
        }

        public StringBuffer(String p) : this()
        {
            this._builder.Append(p.ToString());
        }
        public void append(object p)
        {
            _builder.Append(p);
        }

        public void append(char p)
        {
            _builder.Append(p);
        }

        public String toString()
        {
            return _builder.ToString();
        }

        public int length()
        {
            return _builder.Length;
        }
    }
}
