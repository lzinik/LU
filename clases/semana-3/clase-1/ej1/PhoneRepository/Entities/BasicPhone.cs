using System;
using System.Collections.Generic;

namespace clase_1
{
    public class BasicPhone : CellPhone, IBasicPhone
    {
        // First parameter: Contact ID.
        // Second parameter: Contact Name.
        protected Dictionary<int,string> ContactList = new Dictionary<int,string>();
        protected string OS { get; set; }

        // First parameter: Camera number (it may have more than one).
        // Second parameter: MegaPixels.
        protected Dictionary<string, int> Camera = new Dictionary<string, int>();
        public void Message (int numero){}
    }
}