using System;
using UnityEngine;

namespace UniFramework.Editor
{
    [AttributeUsage(AttributeTargets.Field)]

    public class LabelAttribute : PropertyAttribute
    {
        public string name;

        public LabelAttribute(string name)
        {
            this.name = name;
        }
    }
}