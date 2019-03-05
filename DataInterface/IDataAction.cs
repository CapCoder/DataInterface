using System;
using System.Collections.Generic;
using System.Text;

namespace DataInterface
{
    public interface IDataAction
    {
        void build();
        List<IRow> execute();
        
    }
}
