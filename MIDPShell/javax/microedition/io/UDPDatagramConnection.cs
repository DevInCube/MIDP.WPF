namespace javax.microedition.io
{

    using java.lang;

    public interface UDPDatagramConnection
      //: DatagramConnection
    {
         int getLocalPort()
          ;

         String getLocalAddress()
          ;
    }

}