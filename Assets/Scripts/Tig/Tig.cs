using UnityEngine;

public class Tig : MonoBehaviour
{
    private bool _isCableConnected1 = true;
    private bool _isCableConnected2 = true;
    private bool _isEletricalCurrentButtonOn = false;
    private bool _isLeverOn1 = false;
    private bool _isCaboObraOn = false;
    public PlayContinuousSound playContinuousSound;
    public TochaTig tocha;
    public bool isOn = false;

    void Start()
    {
        _isCableConnected1 = false;
        _isCableConnected2 = false;
        _isEletricalCurrentButtonOn = false;
        _isLeverOn1 = false;
        _isCaboObraOn = false;
    }
    private void UpdateIsOn()
    {
        isOn = _isCableConnected1 && _isCableConnected2 && _isEletricalCurrentButtonOn && _isLeverOn1 && _isCaboObraOn;
        tocha.SetIsMigOn(isOn);
    }

    public void SetIsCableConnected1(bool isCableConnected1)
    {
        _isCableConnected1 = isCableConnected1;
        UpdateIsOn();
    }
    public void SetIsCableConnected2(bool isCableConnected2)
    {
        _isCableConnected2 = isCableConnected2;
        UpdateIsOn();
    }
    public void SetIsEletricalCurrentButtonOn(bool isEletricalCurrentButtonOn)
    {
        _isEletricalCurrentButtonOn = isEletricalCurrentButtonOn;

        UpdateIsOn();
    }
    public void SetIsLeverOn1(bool isLeverOn1)
    {
        _isLeverOn1 = isLeverOn1;
        if (_isLeverOn1)
        {
            playContinuousSound.Play();
        }
        else
        {
            playContinuousSound.Pause();
        }
        UpdateIsOn();
    }
    public void SetIsCaboObraOn(bool isGasOn)
    {
        _isCaboObraOn = isGasOn;
        UpdateIsOn();
    }
}
