using Data;
using JetBrains.Annotations;
using UnityEngine;

namespace Interfaces
{
    public interface IModel
    {
        public void Initilize(Vector3 scale, [CanBeNull]Vector3 position);
    }
}