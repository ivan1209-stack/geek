using Data;
using Interfaces;
using UnityEngine;
using UnityEngine.Serialization;

namespace Models.MapModels
{
    public class Stations : MonoBehaviour, IModel
    {
        [FormerlySerializedAs("_props")] [SerializeField] public LevelProps props;
        private GameObject _model;
        private Rigidbody _rigidBody;


        public void Initilize(Vector3 scale, Vector3 position)
        {
            _model = Object.Instantiate(props.stations[(int)Random.Range(0, props.stations.Count-1)]);
            _rigidBody = _model.AddComponent<Rigidbody>();
            _model.transform.localScale = scale;
            _model.transform.position = position;
        }
        
        public Vector3 Appeal(Vector3 newPosition)
        { 
            _model.transform.position = newPosition; 
            return _model.transform.position;
        }
        
        public Transform Appeal(Vector3 newPosition, Quaternion newRotation)
        { 
            _model.transform.position = newPosition;
            _model.transform.rotation = newRotation;
            return _model.transform;
        }

        public void Appeal(float mass)
        {
            _rigidBody.mass = mass;
        }
        public int CountObject()
        {
            return props.stations.Count;
        }
    }
}