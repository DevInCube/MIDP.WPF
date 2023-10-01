using java.lang;

namespace java.io
{
    public class DataOutputStream : OutputStream
    {

        private readonly OutputStream _stream;

        public DataOutputStream(OutputStream baos)
        {               
            this._stream = baos;
        }

        public void writeByte(byte p)
        {
            _stream.write(p);
        }

        public void writeByte(sbyte p)
        {
            _stream.write(p);
        }

        public void writeShort(short p)
        {
            _stream.write(p >> 8 & 255);
            _stream.write(p & 255);
        }

        public void writeInt(int p)
        {
            _stream.write(p >> 24 & 255);
            _stream.write(p >> 16 & 255);
            _stream.write(p >> 8 & 255);
            _stream.write(p & 255);
        }

        public void writeLong(long p)
        {
            //@todo
        }     

        public void writeUTF(String p)
        {
            string str = p.ToString();
            int length = p.length();
            if (length > 255) throw new System.NotImplementedException();
            //@todo
            byte strLen = (byte)length;
            _stream.write(strLen);
            byte[] bytearr = new byte[strLen];
            int count = 0;
            for (byte x = 0; x < strLen; x++)
            {
                char c = str.ToCharArray()[x];
                if (!((c >= 0x0001) && (c <= 0x007F))) break;
                bytearr[count++] = (byte)c;
            }
            _stream.write(bytearr);
        }

        public override void write(int b)
        {
            _stream.write(b);
        }

        public override void close()
        {
            _stream.close();
        }

        public override void flush()
        {
            _stream.flush();
        }

        public override void write(byte[] bytearr)
        {
            _stream.write(bytearr, 0, bytearr.Length);
        }

        public override void write(byte[] bytearr, int off, int len)
        {
            _stream.write(bytearr, off, len);
        }
    }
}
