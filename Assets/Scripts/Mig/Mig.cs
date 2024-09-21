using UnityEngine;

public class Mig : MonoBehaviour
{
    private bool _isCableConnected1 = true;
    private bool _isCableConnected2 = true;
    private bool _isVoltagemButtonOn = false;
    private bool _isEletricalCurrentButtonOn = false;
    private bool _isLeverOn1 = false;
    private bool _isLeverOn2 = false;
    private bool _isCaboObraOn = false;
    public PlayContinuousSound playContinuousSound;
    public bool isOn = false;
    public TochaMig tochaMig;

    void Start()
    {
        _isCableConnected1 = true;
        _isCableConnected2 = true;
        _isVoltagemButtonOn = false;
        _isEletricalCurrentButtonOn = false;
        _isLeverOn1 = false;
        _isLeverOn2 = false;
        _isCaboObraOn = false;
    }
    private void UpdateIsOn()
    {
        isOn = _isCableConnected1 && _isCableConnected2 && _isVoltagemButtonOn && _isEletricalCurrentButtonOn && _isLeverOn1 && _isLeverOn2 && _isCaboObraOn;
        tochaMig.SetIsMigOn(isOn);
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
    public void SetIsVoltagemButtonOn(bool isVoltagemButtonOn)
    {
        _isVoltagemButtonOn = isVoltagemButtonOn;
        if (_isVoltagemButtonOn)
        {
            playContinuousSound.Play();
        }
        else
        {
            playContinuousSound.Pause();
        }

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
        UpdateIsOn();
    }
    public void SetIsLeverOn2(bool isLeverOn2)
    {
        _isLeverOn2 = isLeverOn2;
        UpdateIsOn();
    }
    public void SetIsCaboObraOn(bool isGasOn)
    {
        _isCaboObraOn = isGasOn;
        UpdateIsOn();
    }
}
