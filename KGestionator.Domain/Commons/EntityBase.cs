using System.Collections.Generic;

namespace KGestionator.Domain.Commons
{
    public abstract class EntityBase<TId>
    {
        public virtual TId Id { get; set; }

        private List<BusinessRule> businessRules = new List<BusinessRule>();

        public List<BusinessRule> BrokenRules
        {
            get { return businessRules; }
        }

        public virtual bool IsValid
        {
            get
            {
                BrokenRules.Clear();
                Validate();
                return BrokenRules.Count == 0;
            }
        }

        protected abstract void Validate();

        protected void AddBrokenRule(BusinessRule businessRule)
        {
            BrokenRules.Add(businessRule);
        }

        public override bool Equals(object entity)
        {
            return entity != null && entity is EntityBase<TId> && this == (EntityBase<TId>)entity;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public static bool operator == (EntityBase<TId> entity1, EntityBase<TId> entity2)
        {
            if ((object)entity1 == null && (object)entity2 == null) return true;
            if ((object)entity1 == null || (object)entity2 == null) return false;
            if (entity1.Id.ToString() == entity2.Id.ToString()) return true;
            return false;
        }

        public static bool operator != (EntityBase<TId> entity1, EntityBase<TId> entity2)
        {
            return !(entity1 == entity2);
        }
    }
}