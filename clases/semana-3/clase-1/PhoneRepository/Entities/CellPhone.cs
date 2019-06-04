using System;
using System.Collections;
using System.Collections.Generic;

namespace clase_1
{
    public class CellPhone : ICellPhone
    {
        protected string Brand { get; set; }
        protected string Model { get; set; }
        protected int Battery { get; set; }
        protected string Proccessor { get; set; }
        protected List<string> Networks = new List<string>();
        protected int Price { get; set; }
        public void Call (int numero){}
        public void Hang(){}
        public void PowerOn(){}
        public void PowerOff(){}
    }
}