﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementEngine.ECS
{
    public interface IComponentStore
    {
        public bool TryRemove(int entityID);
    }

    public class ComponentStore<T> : SparseSet<T>, IComponentStore where T : struct
    {
        public ComponentStore(int maxComponents) : base(maxComponents)
        {
        }
    } // ComponentStore
}
