using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    [Serializable]
    class TVProgram
    {
        public string ProgramName { get; set; }
        public string ProgramChannel { get; set; }
        public double ProgramStart { get; set; }
        public double ProgramEnd { get; set; }
        public string ProgramInfo { get; set; }

        public TVProgram(string pName, string pChannel, double pStart, double pEnd, string pInfo)
        {
            ProgramName = pName;
            ProgramChannel = pChannel;
            ProgramStart = pStart;
            ProgramEnd = pEnd;
            ProgramInfo = pInfo;
        }
    }
}
