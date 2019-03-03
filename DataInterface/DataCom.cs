using System;
using System.Collections.Generic;

namespace DataInterface
{
    public static class DataCom
    {
        public static List<TableRep> tableReps = new List<TableRep>();

        public static void setConnection(string conString, IDBcon context)
        {
            context.connect(conString);
        }
        private static TableRep sendToParser<T>(T classToParse)
        {
            return ParseClass.parseClass(classToParse);
        }
        public static void registerClass<T>(TableRep classToRegister)
        {
            tableReps.Add(sendToParser(classToRegister));
        }

    }
}
