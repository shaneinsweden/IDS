using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ids.Common.Interfaces
{
    public interface IWebDosAnalysis
    {
        bool CheckForWebServerDosAttack(string webServerAddress, int threshold, int? analysisWindow);
    }
}
