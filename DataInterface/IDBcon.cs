using System;
using System.Collections.Generic;
using System.Text;

namespace DataInterface
{
    public interface IDBcon
    {
        void connect(string conString);
        void pushData();
        bool testConnection();
    }
}
