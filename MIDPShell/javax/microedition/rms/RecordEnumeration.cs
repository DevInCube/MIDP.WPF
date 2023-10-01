namespace javax.microedition.rms
{

    public interface RecordEnumeration
    {
        byte[] nextRecord();
        byte[] previousRecord();
        bool hasNextElement();
        bool hasPreviousElement();
        bool isKeptUpdated();
        int nextRecordId();
        int numRecords();
        int previousRecordId();
        void destroy();
        void keepUpdated(bool paramBoolean);
        void rebuild();
        void reset();
    }

}