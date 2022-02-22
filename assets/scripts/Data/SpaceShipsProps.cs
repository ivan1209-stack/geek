using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "SpaceShips", menuName = "SpaceShips", order = 1)]
    public class SpaceShipsProps : ScriptableObject
    {
        public List<GameObject> heavySpaceShips;
        public List<GameObject> easySpaceShips;
        public List<GameObject> reconnaissanceSpaceShips;
        public List<GameObject> mediumSpaceShips;
    }
}
