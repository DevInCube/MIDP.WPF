namespace java.io
{
    public abstract class OutputStream 
    {        

        public OutputStream() 
        {
            
        }

        /// <summary>
        /// Closes this output stream and releases any system resources associated with this stream.
        /// </summary>
        public virtual void	close(){}

        /// <summary>
        /// Flushes this output stream and forces any buffered output bytes to be written out.
        /// </summary>
        public virtual void flush() { }

        /// <summary>
        /// Writes b.length bytes from the specified byte array to this output stream.
        /// </summary>
        /// <param name="b"></param>
        public virtual void write(byte[] b) { }

        /// <summary>
        /// Writes len bytes from the specified byte array starting at offset off to this output stream.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="off"></param>
        /// <param name="len"></param>
        public virtual void	write(byte[] b, int off, int len){}

        /// <summary>
        /// Writes the specified byte to this output stream.
        /// </summary>
        /// <param name="b"></param>
        public abstract void write(int b);
    }
}
