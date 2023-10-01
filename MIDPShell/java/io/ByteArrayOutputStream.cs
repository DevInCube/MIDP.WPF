using java.lang;

namespace java.io
{

    public class ByteArrayOutputStream : OutputStream
    {

        protected System.Collections.Generic.List<byte> buf = new System.Collections.Generic.List<byte>();        

        public ByteArrayOutputStream() { }

        public ByteArrayOutputStream(int capacity) { }

        public byte[] toByteArray()
        {
            return buf.ToArray();
        }

        public int size()
        {
            return buf.Count;
        }

        public String toString()
        {
            return System.Text.Encoding.Default.GetString(buf.ToArray());
        }

        public String toString(String charsetName)
        {
            throw new System.NotImplementedException();
        }

        public override void close()
        { 
            //
        }

        public void reset() { }

        public override void write(byte[] bytearr, int off, int len) 
        {
            for (int i = off; (i - off) < len; i++)
                this.write(bytearr[i]);
        }

        public override void write(int paramInt)
        {
            buf.Add((byte)paramInt);
        }

        public override void flush() { }
    }

}