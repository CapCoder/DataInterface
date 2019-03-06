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
            Dictionary<string, string> tempData = new Dictionary<string, string>(data);
            foreach(string el in data.Keys)
            {
                if (possibleData.ContainsKey(el))
                {
                    string dataFromPossible;
                    possibleData.TryGetValue(el, out dataFromPossible);
                    tempData[el] = dataFromPossible;
                }
            }
            data = tempData;
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
