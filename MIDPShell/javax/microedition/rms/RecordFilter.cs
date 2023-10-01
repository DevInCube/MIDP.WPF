namespace javax.microedition.rms
{

    public interface RecordFilter
    {
        bool matches(byte[] data);
    }

}