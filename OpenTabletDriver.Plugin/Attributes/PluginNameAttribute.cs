﻿using System;

namespace OpenTabletDriver.Plugin.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
    public class PluginNameAttribute : Attribute
    {
        public PluginNameAttribute(string name)
        {
            Name = name;
        }

        public readonly string Name;
    }
}