using System;
using System.Collections.Generic;

namespace clase_1
{
    public class Smartphone : BasicPhone, ISmartphone
    {
        protected Dictionary<int, string> Storage = new Dictionary<int, string>();
        protected Application AppStore = new Application();
        protected string ConnectorType;
        protected string ScreenResolution { get; set; }
    }
}