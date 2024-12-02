using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities._1._6._3._Repository_Base;
using Utilities.Data_Base;

namespace Utilities._1._6._4._Service_Base
{
    public class ServiceBase
    {
        private Dictionary<string, RepositoryBase> _repositories = new Dictionary<string, RepositoryBase>();
        public void AddItem(string key, RepositoryBase value)
        {
            _repositories.Add(key, value);
        }

        public Data RequestProcess(string name, Data data)
        {
            if (_repositories.TryGetValue(name, out RepositoryBase repository))
            {
                RepositoryBase processData = _repositories[name];
                if (processData != null)
                {
                    return processData.ProcessRequest(data);
                }
            }

            return new Data();
        }
    }
}
