using java.lang;
namespace javax.microedition.media
{

    public interface Controllable
    {
        Control[] getControls();        
        Control getControl(String inStr);
    }


}