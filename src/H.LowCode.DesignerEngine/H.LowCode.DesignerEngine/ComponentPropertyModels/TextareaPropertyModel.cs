﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.LowCode.DesignerEngine.ComponentPropertyModels
{
    internal class TextareaPropertyModel : ComponentPropertyModelBase
    {
        private static readonly List<string> _properties = new() { "MaximumLength", "MinimumLength" };

        public override bool IsShowProperty(string propertyName)
        {
            if (_properties.Contains(propertyName))
                return true;
            return false;
        }
    }
}