using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SignalingControl : MonoBehaviour
{
    private AudioSource _audioSource;
    private float _volume;
    
    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void SwichSignalState(bool isSignalPlaying)
    {
        if (isSignalPlaying)
        {
            StartCoroutine(VolumeGrowUp());
        }
        else
        {
            StartCoroutine(VolumeGrowDown());
        }
    }

    private IEnumerator VolumeGrowUp()
    {
        _audioSource.Play();
        _volume = 0;
        
        while (_volume < 1)
        {
            _audioSource.volume = _volume;
            _volume += Time.deltaTime / 4;
            
            yield return null;
        }
    }
    
    private IEnumerator VolumeGrowDown()
    {
        while (_volume > 0)
        {
            _audioSource.volume = _volume;
            _volume -= Time.deltaTime / 4;
            
            yield return null;
        }
        
        _audioSource.Stop();
    }
}
