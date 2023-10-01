namespace javax.microedition.io
{

    
    using java.lang;

    public interface SocketConnection
      //: StreamConnection
    {
        /*
        public static readonly byte DELAY = 0;
        public static readonly byte LINGER = 1;
        public static readonly byte KEEPALIVE = 2;
        public static readonly byte RCVBUF = 3;
        public static readonly byte SNDBUF = 4;
        */
         int getLocalPort();
        

         int getPort();
        

         int getSocketOption(byte paramByte);
        

         String getAddress();
        

         String getLocalAddress();


         void setSocketOption(byte paramByte, int paramInt);
        
    }

}