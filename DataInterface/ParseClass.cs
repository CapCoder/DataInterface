using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DataInterface
{
    public static class ParseClass
    {
        public static TableRep parseClass<T>(T classToParse)
        {
            TableRep tempRep = new TableRep();
            tempRep.setTableName(parseName(classToParse));
            tempRep.tableFields = parseTypes(classToParse);
            return tempRep;
        }

        public static string parseName<T>(T classToParse)
        {
            Type type = classToParse.GetType();
            return type.Name.ToString();
        }

        public static IDictionary<string, TableRep.DType> parseTypes<T>(T classToParse)
        {
            Type type = classToParse.GetType();
            PropertyInfo[] props = type.GetProperties();
            IDictionary<string, TableRep.DType> temp = new Dictionary<string, TableRep.DType>();
            
            
            foreach(PropertyInfo p in props)
            {
                var test = p.PropertyType;

                switch (Type.GetTypeCode(test))
                {
                    case TypeCode.Boolean:
                        temp.Add(p.Name.ToString(), TableRep.DType.boolean);
                        break;
                    case TypeCode.Byte:
                        temp.Add(p.Name.ToString(), TableRep.DType.Tint);
                        break;
                    case TypeCode.Int16:
                        temp.Add(p.Name.ToString(), TableRep.DType.Sint);
                        break;
                    case TypeCode.Int32:
                        temp.Add(p.Name.ToString(), TableRep.DType.Rint);
                        break;
                    case TypeCode.Int64:
                        temp.Add(p.Name.ToString(), TableRep.DType.Lint);
                        break;
                    case TypeCode.Decimal:
                        temp.Add(p.Name.ToString(), TableRep.DType.dec);
                        break;
                    case TypeCode.Double:
                        temp.Add(p.Name.ToString(), TableRep.DType.dec);
                        break;
                    case TypeCode.Char:
                        temp.Add(p.Name.ToString(), TableRep.DType.ch);
                        break;
                    case TypeCode.SByte:
                        temp.Add(p.Name.ToString(), TableRep.DType.Rint);
                        break;
                    case TypeCode.UInt16:
                        temp.Add(p.Name.ToString(), TableRep.DType.Rint);
                        break;
                    case TypeCode.UInt32:
                        temp.Add(p.Name.ToString(), TableRep.DType.Rint);
                        break;
                    case TypeCode.UInt64:
                        temp.Add(p.Name.ToString(), TableRep.DType.Lint);
                        break;
                    case TypeCode.String:
                        temp.Add(p.Name.ToString(), TableRep.DType.vchar);
                        break;
                    default:
                        throw new ArgumentException("Column type is not supported");
                        
                        
                }
            }
            return temp;
        }
    }
}
