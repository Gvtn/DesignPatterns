﻿namespace StructuralPatterns.Composite.CompositeMail
{
    internal abstract class Component
    {
        public abstract string Operation();
        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual bool IsComposite()
        {
            return true;
        }
    }
}