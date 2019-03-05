using System;
using System.Collections.Generic;
using System.Text;

namespace DataInterface
{
    interface IDataCommand : IDataAction
    {
        void addTable(string table);
        void addTables(List<string> tables);
        void addField(string name, TableRep.DType type);
        void addFields(IDictionary<string, TableRep.DType> fields);
    }
}
