using java.lang;
using MIDP.WPF.Data;
using System.Collections.Generic;
namespace javax.microedition.rms
{

    public class RecordStore
    {

        public const int AUTHMODE_PRIVATE = 0;
        public const int AUTHMODE_ANY = 1;

        private static IRecordStoreManager recordStoreManager = new FileRSM();

        private String name;
        private Dictionary<int, byte[]> records = new  Dictionary<int, byte[]>();

        public RecordStore(String name)
        {
            this.name = name;
        }

        public byte[] getRecord(int index)
        {
            if (!records.ContainsKey(index)) throw new InvalidRecordIDException(index.ToString());
            return records[index];            
        }

        public int addRecord(byte[] data, int offset, int numBytes)
        {
            int id = getNextRecordID();
            records.Add(id, data);
            return id;
        }

        public int getNextRecordID()
        {
            return getNumRecords() + 1;
        }

        public int getNumRecords()
        {
            return records.Count;
        }

        public int getRecord(int recordId, byte[] buffer, int offset)
        {
            return 0;
        }

        public int getRecordSize(int recordId)
        {
            return 0;
        }

        public int getSize()
        {
            return 0;
        }

        public int getSizeAvailable()
        {
            return int.MaxValue; //@todo
        }

        public int getVersion()
        {
            return 0;
        }

        public String getName()
        {
            return name;
        }

        public RecordEnumeration enumerateRecords(RecordFilter f, RecordComparator c, bool paramBoolean)
        {
            return new RecordList(records);
        }

        public long getLastModified()
        {
            return 0L;
        }

        public static String[] listRecordStores()
        {
            return null;
        }

        public static RecordStore openRecordStore(String recordStoreName, bool createIfNecessary)
        {
            if (string.IsNullOrEmpty(recordStoreName)) throw new IllegalArgumentException("recordStoreName");

            RecordStore rs = null;
            if (recordStoreManager.Contains(recordStoreName))
            {
                rs = recordStoreManager.Get(recordStoreName);
            }
            else
            {
                if (createIfNecessary)
                {
                    recordStoreManager.Create(recordStoreName);
                    rs = recordStoreManager.Get(recordStoreName);
                }
                else
                {
                    throw new RecordStoreNotFoundException(recordStoreName);
                }
            }
            recordStoreManager.Open(rs.getName());
            return rs;
        }

        public static RecordStore openRecordStore(String recordStoreName, bool createIfNecessary, int authmode, bool writable)
        {
            RecordStore store = openRecordStore(recordStoreName, createIfNecessary);
            //@todo
            return store;
        }

        /// <summary>
        ///  Open a record store associated with the named MIDlet suite.
        /// </summary>
        /// <param name="recordStoreName"></param>
        /// <param name="vendorName"></param>
        /// <param name="suiteName"></param>
        /// <returns></returns>
        public static RecordStore openRecordStore(String recordStoreName, String vendorName, String suiteName)
        {
            return null;
        }

        public static void deleteRecordStore(String name)
        {
            recordStoreManager.Delete(name);
        }

        public void addRecordListener(RecordListener listenter) 
        { 
            //
        }

        public void closeRecordStore()
        {
            recordStoreManager.Close(this.getName());
        }

        public void deleteRecord(int paramInt)
        {
            records.Remove(paramInt);
        }

        public void removeRecordListener(RecordListener paramRecordListener) { }

        public void setMode(int paramInt, bool paramBoolean) { }

        public void setRecord(int recordId, byte[] newData, int offset, int numBytes)
        {            
            records[recordId] = newData; //@todo offset numBytes
        }
    }

}