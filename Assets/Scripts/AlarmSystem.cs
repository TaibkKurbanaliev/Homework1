using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AlarmSystem : MonoBehaviour
{
    [SerializeField] AudioSource sound;
    [SerializeField] private float _time;
    [SerializeField] private float _runnigTime;

    private bool _isActive = false;
    private float _maxVolume = 1;
    private float _minVolume = 0;

    private void Update()
    {
        _runnigTime += Time.deltaTime;

        if (sound.volume >= 0)
        {
            if (_isActive)
            {
                sound.volume += 0.001f;
            }
            else
            {
                sound.volume -= 0.001f;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Player>(out Player player))
        {
            _isActive = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<Player>(out Player player))
        {
            _isActive = false;
        }
    }
}
