using System;

namespace BookManagementSystem.Entities.Attributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true)]
    [Serializable]
    public class NotMappingAttribute : Attribute
    {
    }
}