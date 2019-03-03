using System;
using System.Collections.Generic;

namespace DataInterface
{
    public static class DataCom
    {
        public static List<TableRep> tableReps = new List<TableRep>();

        private static TableRep sendToParser<T>(T classToParse)
        {
            return ParseClass.parseClass(classToParse);
        }
    }
}
