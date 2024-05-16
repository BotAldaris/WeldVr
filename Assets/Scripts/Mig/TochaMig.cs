using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TochaMig : MonoBehaviour
{
    public CreateTrail createTrail;
    public  ParticleSystem ParticleSystem;
    private bool _isActive;
    private bool _isInWeldArea;
    private bool _isMigOn;
    private bool on;
    private PlayContinuousSound continuousSound;
    private PlayQuickSound quickSound;      
    // Start is called before the first frame update
    void Start()
    {
        continuousSound = GetComponent<PlayContinuousSound>();
        quickSound = GetComponent<PlayQuickSound>();
    }

    public void SetIsMigOn(bool isMigOn)
    {
        _isMigOn = isMigOn;
        TryDraw();
    }

    public void SetIsActive(bool isActive)
    {
        _isActive = isActive;
        TryDraw();
    }
    public void SetIsInWeldArea(bool isInWeldArea)
    {
        _isInWeldArea = isInWeldArea;
        TryDraw();
    }
    public void TryDraw()
    {
        if (_isActive && _isInWeldArea && _isMigOn && !on) { 
            createTrail.StartTrail();
            continuousSound.Play();
            quickSound.Play();
            ParticleSystem.Play();
            on = true;
        }else if (!(_isActive && _isInWeldArea && _isMigOn) && on) { 
            createTrail.EndTrail(); 
            continuousSound.Pause();
            ParticleSystem.Stop();
            on = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Area Solda"))
        {
            SetIsInWeldArea(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Area Solda"))
        {
            SetIsInWeldArea(false);
        }
    }
}
