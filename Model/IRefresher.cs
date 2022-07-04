using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public interface IRefreshable<T>
    {
        void OnListChanged(object key);
    }
}
