using Data;
using Interfaces;
using UnityEngine;

namespace Models.MapModels
{
    public class Stations : MonoBehaviour, IModel
    {
        [SerializeField] private LevelProps _props;
        private GameObject _model;
        private Rigidbody _rigidBody;


        public void Initilize(int index, Vector3 scale, Vector3 position)
        {
            _model = Object.Instantiate(_props.stations[index]);
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
            return _props.stations.Count;
        }
    }
}