using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDP.WPF.Data
{
    public interface IRecordStoreManager
    {
        void Create(java.lang.String recordStoreName);
        javax.microedition.rms.RecordStore Get(java.lang.String recordStoreName);
        bool Contains(java.lang.String recordStoreName);
        void Delete(java.lang.String recordStoreName);
        void Open(java.lang.String recordStoreName);
        void Close(java.lang.String recordStoreName);
    }
}
