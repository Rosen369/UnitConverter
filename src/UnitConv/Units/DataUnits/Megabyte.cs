﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.DataUnits
{
    class Megabyte : DataUnit
    {
        private class Nested
        {
            internal static readonly Megabyte Instance = new Megabyte();
        }

        private Megabyte()
        {

        }

        public static Megabyte GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "兆字节" },
                { Languages.English, "megabyte" },
                { Languages.Symbol, "MB" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1 / 1024m / 1024m;
        }
    }
}
