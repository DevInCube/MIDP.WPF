using javax.microedition.rms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDP.WPF.Data
{
    public class FileRSM : IRecordStoreManager
    {

        private string rmsRoot = "rms";
        private Dictionary<string, RecordStore> stores = new Dictionary<string, RecordStore>();


        public FileRSM()
        {
            Directory.CreateDirectory(rmsRoot);
        }

        public void Create(java.lang.String recordStoreName)
        {
            Directory.CreateDirectory(Path.Combine(rmsRoot, recordStoreName));
        }

        public javax.microedition.rms.RecordStore Get(java.lang.String recordStoreName)
        {
            if (!stores.ContainsKey(recordStoreName))
            {
                var rs = new RecordStore(recordStoreName);
                stores.Add(recordStoreName, rs);
                return rs;
            }
            return stores[recordStoreName];
        }

        public bool Contains(java.lang.String recordStoreName)
        {
            return System.IO.Directory.Exists(System.IO.Path.Combine(rmsRoot, recordStoreName));
        }

        public void Delete(java.lang.String recordStoreName)
        {
            System.IO.Directory.Delete(System.IO.Path.Combine(rmsRoot, recordStoreName), true);
        }

        public void Open(java.lang.String recordStoreName)
        {
            var rs = stores[recordStoreName];
            string[] files = Directory.EnumerateFiles(Path.Combine(rmsRoot, recordStoreName)).ToArray();            
            foreach (var file in files)
            {
                byte[] data = File.ReadAllBytes(file);
                rs.setRecord(int.Parse(Path.GetFileName(file)), data, 0, 0);
            }
        }

        public void Close(java.lang.String recordStoreName)
        {
            var rs = stores[recordStoreName];
            var list = rs.enumerateRecords(null, null, false); //@todo
            while (list.hasNextElement())
            {
                int index = list.nextRecordId();
                string path = Path.Combine(new string[] { rmsRoot, recordStoreName, index.ToString() });
                byte[] data = rs.getRecord(index);
                if (data != null)
                    File.WriteAllBytes(path, data);
            }          
        }
    }
}
