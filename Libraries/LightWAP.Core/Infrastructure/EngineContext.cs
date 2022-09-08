using LightWAP.Core.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LightWAP.Core.Infrastructure
{
    public class EngineContext
    {

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static IEngine Create()
        {
            return Singleton<IEngine>.Instance ?? (Singleton<IEngine>.Instance = new LightWAPEngine());
        }

    }
}
