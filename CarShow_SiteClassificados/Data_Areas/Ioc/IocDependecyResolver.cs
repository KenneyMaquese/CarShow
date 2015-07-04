using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Data_Areas.Ioc
{
    public class IocDependecyResolver : IDependencyResolver
    {
        public object GetService(Type serviceType)
        {
            return Resolve.Get(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return Resolve.GetAll(serviceType);
        }
    }
}
