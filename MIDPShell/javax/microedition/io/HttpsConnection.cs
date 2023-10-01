namespace javax.microedition.io
{

    

    public interface HttpsConnection
      : HttpConnection
    {
        int getPort();

        SecurityInfo getSecurityInfo()
          ;
    }

}