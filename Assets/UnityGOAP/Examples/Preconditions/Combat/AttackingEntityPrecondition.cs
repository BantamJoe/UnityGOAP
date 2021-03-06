﻿using UnityGOAP.Examples.Preconditions.Entity;

namespace UnityGOAP.Examples.Preconditions.Combat {
    public class AttackingEntityPrecondition : EntityPrecondition {
        public Examples.Entity Target;
        
        public override bool IsMet(GOAPAgent agent) {
            return Entity.EntityState.GetValue(StateVariables.IsAttacking(Target));
        }
    }
}