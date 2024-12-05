using UnityEditor;
using UnityEngine;

namespace UniFramework.Editor
{
    [CustomPropertyDrawer(typeof(LabelAttribute))]
    public class LabelAttributeDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            LabelAttribute attr = (LabelAttribute)attribute;
            if (attr.name.Length > 0)
            {
                label.text = attr.name;
            }

            EditorGUI.PropertyField(position, property, label);
        }
    }
}