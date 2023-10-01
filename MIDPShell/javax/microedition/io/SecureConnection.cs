namespace javax.microedition.io
{

    

    public  interface SecureConnection
      : SocketConnection
    {
        SecurityInfo getSecurityInfo();
    }
}