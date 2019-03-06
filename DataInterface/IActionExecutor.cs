using System;
using System.Collections.Generic;
using System.Text;

namespace DataInterface
{
    public interface IActionExecutor
    {
        Row runQueries(List<IDataAction> action);
        void registerQuery(IDataAction action);
    }
}
