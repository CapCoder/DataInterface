using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DataInterface;

namespace DataInterfaceTests
{
    public class DataComTests
    {
        private class testClass
        {
            public bool boolTest { get; set; }
            public byte byteTest { get; set; }
            public short shortTest { get; set; }
            public int intTest { get; set; }
            public long longTest { get; set; }
            public decimal decimalTest { get; set; }
            public double doubleTest { get; set; }
            public char charTest { get; set; }
            public sbyte sbyteTest { get; set; }
            public ushort ushortTest { get; set; }
            public uint uintTest { get; set; }
            public ulong ulongTest { get; set; }
            public string stringTest { get; set; }
        }
        private IDictionary<string, TableRep.DType> testComp = new Dictionary<string, TableRep.DType>();
        [Fact]
        public void sendToParserShouldWork()
        {
            testClass tester = new testClass();
            testComp.Add("boolTest", TableRep.DType.boolean);
            testComp.Add("byteTest", TableRep.DType.Tint);
            testComp.Add("shortTest", TableRep.DType.Sint);
            testComp.Add("intTest", TableRep.DType.Rint);
            testComp.Add("longTest", TableRep.DType.Lint);
            testComp.Add("decimalTest", TableRep.DType.dec);
            testComp.Add("doubleTest", TableRep.DType.dec);
            testComp.Add("charTest", TableRep.DType.ch);
            testComp.Add("sbyteTest", TableRep.DType.Rint);
            testComp.Add("ushortTest", TableRep.DType.Rint);
            testComp.Add("uintTest", TableRep.DType.Rint);
            testComp.Add("ulongTest", TableRep.DType.Lint);
            testComp.Add("stringTest", TableRep.DType.vchar);

            TableRep testCompTableRep = new TableRep();
            testCompTableRep.setTableName("testClass");
            testCompTableRep.setColumns(testComp);

            
        }
    }
}
