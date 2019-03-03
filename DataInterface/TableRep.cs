using System;
using System.Collections.Generic;
using System.Text;

namespace DataInterface
{
    public class TableRep
    {
        public string tableName;
        public IDictionary<string, DType> tableFields;
        public enum DType
        {
            boolean,
            Tint,
            Sint,
            Rint,
            Lint,
            real,
            dec,
            vchar,
            ch,
        };

        public void setTableName(string name)
        {
            if(name == null || name == "")
            {
                throw new ArgumentException("Table name cannot be blank or null");
            }
            else
            {
                this.tableName = name;
            }
            
        }

        public void addField(string name, DType type)
        {
            tableFields.Add(name, type);
        }

        public void removeField(string name)
        {
            tableFields.Remove(name);
        }


    }
}
