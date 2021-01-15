using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador_RGB.Internals
{
    public static class Events
    {
        public delegate void loadingComPort();
        public static event loadingComPort LoadComPort;

        public static void loadComportEvent() { if (LoadComPort != null) LoadComPort.Invoke(); }

    }
}
