namespace javax.microedition.media.control
{

    

    public interface VolumeControl
      : Control
    {
        bool isMuted();

        int getLevel();

        int setLevel(int paramInt);

        void setMute(bool paramBoolean);
    }


}