namespace javax.microedition.rms
{

    public enum RecordComparatorResult
    {
        PRECEDES = -1,
        EQUIVALENT = 0,
        FOLLOWS = 1
    }

    public interface RecordComparator 
    {
        /*
        public static readonly int PRECEDES = -1;
        public static readonly int EQUIVALENT = 0;
        public static readonly int FOLLOWS = 1;
        */
        int compare(byte[] data1, byte[] data2);
    }

}
