using javax.microedition.rms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDP.WPF.Data
{
    public class MemoryRSM : IRecordStoreManager
    {

        private Dictionary<string, RecordStore> stores = new Dictionary<string, RecordStore>();

        internal void Create(java.lang.String recordStoreName)
        {
            stores.Add(recordStoreName.ToString(), new RecordStore(recordStoreName));
        }

        internal javax.microedition.rms.RecordStore Get(java.lang.String recordStoreName)
        {
            return stores[recordStoreName.ToString()];
        }

        internal bool Contains(java.lang.String recordStoreName)
        {
            return stores.ContainsKey(recordStoreName.ToString());
        }

        internal void Delete(java.lang.String name)
        {
            throw new NotImplementedException();
        }

        void IRecordStoreManager.Create(java.lang.String recordStoreName)
        {
            throw new NotImplementedException();
        }

        RecordStore IRecordStoreManager.Get(java.lang.String recordStoreName)
        {
            throw new NotImplementedException();
        }

        bool IRecordStoreManager.Contains(java.lang.String recordStoreName)
        {
            throw new NotImplementedException();
        }

        void IRecordStoreManager.Delete(java.lang.String recordStoreName)
        {
            throw new NotImplementedException();
        }

        public void Open(java.lang.String recordStoreName)
        {
            throw new NotImplementedException();
        }

        public void Close(java.lang.String recordStoreName)
        {
            throw new NotImplementedException();
        }
    }
}
