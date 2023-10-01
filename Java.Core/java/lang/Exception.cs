namespace java.lang
{
    public class Exception : System.Exception
    {

        public Exception() { }

        public Exception(String msg):base(msg.ToString()) { }

        public void printStackTrace()
        {
            //
        }

        public String toString()
        {
            return this.ToString();
        }
    }
}
