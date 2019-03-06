using System;
using System.Collections.Generic;
using System.Text;
using DataInterface;
using Xunit;

namespace DataInterfaceTests
{
    public class RowTests
    {

        [Fact]
        public void setFieldsShouldWork()
        {
            IDictionary<string, TableRep.DType> test = new Dictionary<string, TableRep.DType>();
            IDictionary<string, string> dataComp = new Dictionary<string, string>();

            test.Add("boolTest", TableRep.DType.boolean);
            test.Add("byteTest", TableRep.DType.Tint);
            test.Add("shortTest", TableRep.DType.Sint);
            test.Add("intTest", TableRep.DType.Rint);
            test.Add("longTest", TableRep.DType.Lint);
            test.Add("decimalTest", TableRep.DType.dec);
            test.Add("doubleTest", TableRep.DType.dec);
            test.Add("charTest", TableRep.DType.ch);
            test.Add("sbyteTest", TableRep.DType.Rint);
            test.Add("ushortTest", TableRep.DType.Rint);
            test.Add("uintTest", TableRep.DType.Rint);
            test.Add("ulongTest", TableRep.DType.Lint);
            test.Add("stringTest", TableRep.DType.vchar);

            dataComp.Add("boolTest", "");
            dataComp.Add("byteTest", "");
            dataComp.Add("shortTest", "");
            dataComp.Add("intTest", "");
            dataComp.Add("longTest", "");
            dataComp.Add("decimalTest", "");
            dataComp.Add("doubleTest", "");
            dataComp.Add("charTest", "");
            dataComp.Add("sbyteTest", "");
            dataComp.Add("ushortTest", "");
            dataComp.Add("uintTest", "");
            dataComp.Add("ulongTest", "");
            dataComp.Add("stringTest", "");

            Row testRow = new Row();

            testRow.setFields(test);
            

            Assert.Equal(test, testRow.getRowFields());
            Assert.Equal(dataComp, testRow.getDataFields());
        }
    }
}
