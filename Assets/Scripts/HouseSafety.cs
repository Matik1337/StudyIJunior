using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseSafety : MonoBehaviour
{
    private SignalingSwither _signalingControl;
    private bool _isSignalPlaying;
    
    private void Awake()
    {
        _signalingControl = GetComponentInChildren<SignalingSwither>();
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerMovement playerMovement;
        
        if (other.gameObject.TryGetComponent(out playerMovement))
        {
            _isSignalPlaying = true;
            _signalingControl.SwichSignalState(_isSignalPlaying);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PlayerMovement playerMovement;
        
        if (other.gameObject.TryGetComponent(out playerMovement))
        {
            _isSignalPlaying = false;
            _signalingControl.SwichSignalState(_isSignalPlaying);        
        }
    }
}
