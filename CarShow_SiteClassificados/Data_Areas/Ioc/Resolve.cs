using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Data_Areas.Ioc
{
    public class Resolve
    {
        private static StandardKernel _kernel = new StandardKernel(new IocModule());
        public static object Get(Type type)
        {
            return _kernel.TryGet(type);
        }

        public static IEnumerable<object> GetAll(Type type)
        {
            return _kernel.GetAll(type);
        }
    }
}
