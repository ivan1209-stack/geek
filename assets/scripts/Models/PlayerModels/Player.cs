using System;
using Data;
using Interfaces;
using Models.Additionally;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Models.PlayerModels
{
    public class Player : IPlayerModel
    {
        [SerializeField] private SpaceShipsProps _props;
        private GameObject _model;
        private float _acceleration;
        private Team _team;
        private Rigidbody _rigidbody;
        
        private GameObject Separator(int list, int index)
        {
            return list switch
            {
                0 => _props.reconnaissanceSpaceShips[index],
                1 => _props.easySpaceShips[index],
                2 => _props.mediumSpaceShips[index],
                3 => _props.heavySpaceShips[index],
                _ => throw new IndexOutOfRangeException()
            };
        }
        
        public void Initilize(int list, int index, Vector3 scale, Vector3 position, float acceleration, Team team)
        {
            _model = Object.Instantiate(Separator(list, index));
            _model.transform.localScale = scale;
            _model.transform.position = position;
            _acceleration = acceleration;
            _team = team;
            _rigidbody = _model.AddComponent<Rigidbody>();
        }

        public Quaternion GetRotation() => _model.transform.rotation;
        public float GetSpeed() => _rigidbody.velocity.magnitude;
        public void SetAcceleration(float acceleration) => _acceleration = acceleration;
        public float GetAcceleration() => _acceleration;
    }
}