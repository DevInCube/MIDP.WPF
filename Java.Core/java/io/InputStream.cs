using System.IO;

namespace java.io
{
    public abstract class InputStream
    {
        private readonly Stream _stream;

        public Stream Stream => _stream;

        public InputStream(byte[] bytes)
        {
            _stream = new MemoryStream(bytes);
        }

        public InputStream(InputStream stream)
        {
            _stream = stream._stream;
        }

        public InputStream(Stream fileStream)
        {
            _stream = fileStream;
            _stream.Seek(0, SeekOrigin.Begin);
        }

        public byte read()
        {
            return (byte)_stream.ReadByte();
        }

        public void close()
        {
            _stream.Close();
        }
    }
}
