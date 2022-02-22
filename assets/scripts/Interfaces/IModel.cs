using JetBrains.Annotations;
using UnityEngine;

namespace Interfaces
{
    public interface IModel
    {
        public void Initilize(int index, Vector3 scale, [CanBeNull]Vector3 position);
        public int CountObject();
    }
}