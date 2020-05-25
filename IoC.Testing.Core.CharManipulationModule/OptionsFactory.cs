using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.Testing.Core.CharManipulationModule
{
    public class OptionsFactory
    {
        internal string prefix;

        public void SetPrefix(string value)
        {
            prefix = value;
        }
    }
}
