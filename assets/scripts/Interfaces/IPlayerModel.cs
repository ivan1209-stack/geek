using Models.Additionally;
using UnityEngine;

namespace Interfaces
{
    public interface IPlayerModel
    {
        public void Initilize(int list, int index, Vector3 scale, Vector3 position, float acceleration, Team team);
    }
}