namespace javax.microedition.rms
{

    public interface RecordListener
    {
        void recordAdded(RecordStore rStore, int index);
        void recordChanged(RecordStore rStore, int index);
        void recordDeleted(RecordStore rStore, int index);
    }

}