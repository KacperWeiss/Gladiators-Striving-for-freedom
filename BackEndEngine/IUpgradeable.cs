using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    /// <summary>
    /// Interface for classes that are able to be upgraded
    /// </summary>
    interface IUpgradeable
    {
        void Upgrade(ref decimal funds);
    }
}
