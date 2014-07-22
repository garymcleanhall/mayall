using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayall.contracts
{
    public interface IConfigDataProvider
    {
        ConfigData GetConfigData();

        void SetConfigData(ConfigData data);
    }
}
