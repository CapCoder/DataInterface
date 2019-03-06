using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace DataInterface
{
    public class Row
    {
        private IDictionary<string, TableRep.DType> rowFields;
        private IDictionary<string, string> data;

        public Row()
        {
            rowFields = new Dictionary<string, TableRep.DType>();
            data = new Dictionary<string, string>();
        }
        public void setFields(IDictionary<string, TableRep.DType> fields)
        {
            this.rowFields = fields;
            populateDataKeys();
        }

        public void setData(IDictionary<string, string> possibleData)
        {
            foreach(var el in data)
            {
                if (possibleData.ContainsKey(el.Key))
                {
                    string data;
                    possibleData.TryGetValue(el.Key, out data);
                    el.Value.Replace("", data);
                }
            }
        }

        private void populateDataKeys()
        {
            foreach(string x in rowFields.Keys)
            {
                data.Add(x, "");
            }
        }

        public IDictionary<string, TableRep.DType> getRowFields()
        {
            return rowFields;
        }
        
        public IDictionary<string, string> getDataFields()
        {
            return data;
        }
    }
}
