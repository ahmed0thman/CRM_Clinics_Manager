﻿namespace Clinic.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }

    public abstract class EntityBase
    {
        public EntityStateOption EntityState { get; set; }
        public bool IsNew { get; private set; }
        public bool HasChanged { get; set; }
        public bool IsValid => Validate();

        public abstract bool Validate();
    }
}
