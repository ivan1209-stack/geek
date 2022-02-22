using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Data
{
    [CreateAssetMenu(fileName = "levelProps", menuName = "levelProps", order = 0)]
    public class LevelProps : ScriptableObject
    {
        [SerializeField] public List<GameObject> planets;
        [SerializeField] public List<GameObject> asteroids;
        [SerializeField] public List<GameObject> massiveObjects;
        [SerializeField] public List<GameObject> massiveObjectsWholes;
        [SerializeField] public List<GameObject> stations;
    }
}