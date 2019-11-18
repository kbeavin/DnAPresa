using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnAScreener.Processors
{
    class DriverProcessor
    {
        public Object Get_DriverPreview(DataMgr sender)
        {
            DataMgr context = new DataMgr();
            context.Connect();


            context.Disconnect();

            return null;
        }
    }
}
