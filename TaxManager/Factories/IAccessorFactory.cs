using System;
using System.Collections.Generic;
using System.Text;

namespace TaxManagerApp.Accessors
{
    public interface IAccessorFactory
    {
        T CreateAccessor<T>(string subType = "") where T : class;
    }
}
