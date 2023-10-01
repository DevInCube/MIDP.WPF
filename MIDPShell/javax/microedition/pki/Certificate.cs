using java.lang;
namespace javax.microedition.pki
{

    public interface Certificate
    {
         String getIssuer();
         String getSerialNumber();
         String getSigAlgName();
         String getSubject();
         String getType();
         String getVersion();
         long getNotAfter();
         long getNotBefore();
    }

}