using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSignaling : MonoBehaviour
{
    private Signaling _signaling;

    private void OnEnable()
    {
        _signaling = GetComponent<Signaling>();

        _signaling.Signaled += OnEndPointReached;
    }

    private void OnDisable()
    {
        _signaling.Signaled -= OnEndPointReached;
    }

    private void OnEndPointReached()
    {
        if (_signaling.IsSignaling == false)
            return;

        //Debug.Log("Signaling is Over");
    }
}
