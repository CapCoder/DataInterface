using System;
using System.Collections.Generic;
using System.Text;

namespace DataInterface
{
    public interface IActionExecutor
    {
        List<IRow> runQueries(List<IDataAction> action);
        void registerQuery(IDataAction action);
    }
}
