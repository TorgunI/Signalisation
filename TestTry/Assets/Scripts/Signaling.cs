using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Signaling : MonoBehaviour
{
    [SerializeField] private UnityEvent _signaled = new UnityEvent();

    [SerializeField] private AudioSource _audioAlarm;

    public bool IsSignaling { get; private set; }

    public event UnityAction Signaled
    {
        add => _signaled.AddListener(value);
        remove => _signaled.RemoveListener(value);
    }

    private void Awake()
    {
        //audioAlarm = GetComponent<AudioSource>();

        IsSignaling = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            if (IsSignaling)
            {
                Debug.Log("Откл.");
                IsSignaling = false;

                _audioAlarm.loop = false;
                return;
            }

            IsSignaling = true;
            _audioAlarm.loop = true;

            _signaled.Invoke();
        }
    }
}
