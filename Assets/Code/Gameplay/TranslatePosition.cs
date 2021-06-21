using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FrogGame
{
    public class TranslatePosition : MonoBehaviour
    {
        [SerializeField] private Vector2 _direction;
        [SerializeField] private float _speed;

        private int _liveTime = 1000;
        private int _currentLiveTime;

        private void Update()
        {
            TimeDestroy();
        }

        void FixedUpdate()
        {
            transform.Translate(_speed * _direction * Time.deltaTime, Space.World);
        }

        private void TimeDestroy()
        {
            if (_currentLiveTime < _liveTime)
                _currentLiveTime++;
            else Destroy(this.gameObject);
        }
    }
}
