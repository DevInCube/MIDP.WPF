using javax.microedition.rms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDP.WPF.Data
{
    public class RecordList : RecordEnumeration
    {
        private Dictionary<int, byte[]> records;
        private int pos = 0;

        public RecordList(Dictionary<int, byte[]> records)
        {
            this.records = records;
        }

        public byte[] nextRecord()
        {
            throw new NotImplementedException();
        }

        public byte[] previousRecord()
        {
            throw new NotImplementedException();
        }

        public bool hasNextElement()
        {
            return pos < records.Count;
        }

        public bool hasPreviousElement()
        {
            throw new NotImplementedException();
        }

        public bool isKeptUpdated()
        {
            throw new NotImplementedException();
        }

        public int nextRecordId()
        {
            return records.ToList()[pos++].Key;
        }

        public int numRecords()
        {
            return records.Count;
        }

        public int previousRecordId()
        {
            throw new NotImplementedException();
        }

        public void destroy()
        {
            throw new NotImplementedException();
        }

        public void keepUpdated(bool paramBoolean)
        {
            throw new NotImplementedException();
        }

        public void rebuild()
        {
            throw new NotImplementedException();
        }

        public void reset()
        {
            pos = 0;
        }
    }
}
