using System;
using System.Collections.Generic;
using System.Text;

namespace DataInterface
{
    interface IDataQuery : IDataAction
    {
        void setTable(string table);
        void setColumns(List<string> fields);
    }
}
