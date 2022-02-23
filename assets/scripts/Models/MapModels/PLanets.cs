using Data;
using Interfaces;
using UnityEngine;
using UnityEngine.Serialization;

namespace Models.MapModels
{
    public class PLanets : MonoBehaviour, IModel
    {
        [FormerlySerializedAs("_props")] [SerializeField] public LevelProps props;
        private GameObject _model;


        public void Initilize(Vector3 scale, Vector3 position)
        {
            _model = Object.Instantiate(props.planets[(int)Random.Range(0, props.planets.Count-1)]); 
            _model.transform.localScale = scale;
            _model.transform.position = position;
        }
        
        public Vector3 Appeal(Vector3 newPosition)
        { 
            _model.transform.position = newPosition; 
            return _model.transform.position;
        }
        public int CountObject()
        {
            return props.planets.Count;
        }
    }
}