﻿namespace Rusty.CSharpGenerator
{
    public class GenericConstraint : ClassInheritance
    {
        /* Public properties. */
        public string Name { get; set; }

        /* Constructors. */
        public GenericConstraint() : base() { }

        public GenericConstraint(GenericConstraint other) : base(other) { }

        public GenericConstraint(string name, string baseClass) : base(baseClass)
        {
            Name = name;
        }

        public GenericConstraint(string name, ArgumentList interfaces) : base("", interfaces)
        {
            Name = name;
        }

        public GenericConstraint(string name, string baseClass, ArgumentList interfaces) : base(baseClass, interfaces)
        {
            Name = name;
        }

        /* Public methods. */
        public override Generator Copy()
        {
            return new GenericConstraint(this);
        }

        public override string Generate()
        {
            string code = base.Generate();
            if (code == "")
                return "";
            else
                return $"where {Name}{code}";
        }
    }
}