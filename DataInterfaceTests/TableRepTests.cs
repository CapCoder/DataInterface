using System;
using System.Collections.Generic;
using System.Text;
using DataInterface;
using Xunit;

namespace DataInterfaceTests
{
    public class TableRepTests
    {
        [Theory]
        [InlineData("thisName", "thisName")]
        public void setTableNameShouldWork(string test, string expected)
        {
            TableRep testComp = new TableRep();
            testComp.setTableName(test);

            Assert.Equal(testComp.tableName, expected);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void setTableShouldThrowException(string test)
        {
            TableRep testComp = new TableRep();

            Assert.Throws<ArgumentException>(() => testComp.setTableName(test));
        }
    }
}
