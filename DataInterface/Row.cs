using System;
using System.Collections.Generic;
using System.Text;

namespace DataInterface
{
    class Row
    {
        private IDictionary<string, TableRep.DType> rowFields;
        private IDictionary<string, string> data;

        public void setFields(IDictionary<string, TableRep.DType> fields)
        {
            this.rowFields = fields;
        }

        public void setData(IDictionary<string, string> possibleData)
        {
            
        }
    }
}
