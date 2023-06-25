using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAPP.Services
{
    public class CondominiosApiFactory
    {
        public static ICondominiosApi GetApi()
        {
            var api = Configuration.GetInstance().GetApiPath();
            return RestService.For<ICondominiosApi>(api);
        }
    }
}
