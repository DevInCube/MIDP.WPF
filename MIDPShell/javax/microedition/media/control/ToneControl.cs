namespace javax.microedition.media.control
{

    

    public interface ToneControl 
      : Control//interface
    {
        /*
        public static readonly byte SILENCE = -1;
        public static readonly byte VERSION = -2;
        public static readonly byte TEMPO = -3;
        public static readonly byte RESOLUTION = -4;
        public static readonly byte BLOCK_START = -5;
        public static readonly byte BLOCK_END = -6;
        public static readonly byte PLAY_BLOCK = -7;
        public static readonly byte SET_VOLUME = -8;
        public static readonly byte REPEAT = -9;
        public static readonly byte C4 = 60;
        */
       void setSequence(byte[] paramArrayOfByte);
    }

}