using System;
using System.Collections.Generic;
using System.Text;
using DataInterface;
using Xunit;

namespace DataInterfaceTests
{
    public class RowTests
    {
        IDictionary<string, TableRep.DType> test = new Dictionary<string, TableRep.DType>();
        IDictionary<string, string> dataComp = new Dictionary<string, string>();

        [Fact]
        public void setFieldsShouldWork()
        {
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

        [Fact]
        public void setDataShouldWork()
        {
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

            dataComp.Add("boolTest", "true");
            dataComp.Add("byteTest", "c");
            dataComp.Add("shortTest", "23");
            dataComp.Add("intTest", "13");
            dataComp.Add("longTest", "142");
            dataComp.Add("decimalTest", "2.4");
            dataComp.Add("doubleTest", "34.5");
            dataComp.Add("charTest", "e");
            dataComp.Add("sbyteTest", "3");
            dataComp.Add("ushortTest", "23");
            dataComp.Add("uintTest", "34");
            dataComp.Add("ulongTest", "345");
            dataComp.Add("stringTest", "hello");

            Row testRow = new Row();
            testRow.setFields(test);
            testRow.setData(dataComp);

            Assert.Equal(dataComp, testRow.getDataFields());
        }
    }
}
