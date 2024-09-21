using UnityEngine;

public class TochaMig : MonoBehaviour
{
    public CreateTrail createTrail;
    public ParticleSystem ParticleSystem;
    private bool _isActive;
    private bool _isInWeldArea;
    private bool _isMigOn;
    private bool _isGasOn;
    private bool on;
    private PlayContinuousSound continuousSound;
    private PlayQuickSound quickSound;
    public Material skyboxMaterial; // Associe o material do Skybox no Inspector
    private Color backgroundColor = Color.black;
    private Light[] lights;
    public Light light1;
    private Color azul;
    public Color vermelo;
    public EPIManage manage;
    // Start is called before the first frame update
    void Start()
    {
        lights = FindObjectsByType<Light>(sortMode: FindObjectsSortMode.None);
        continuousSound = GetComponent<PlayContinuousSound>();
        quickSound = GetComponent<PlayQuickSound>();
        azul = light1.color;
    }

    public void SetIsGasOn(bool isGasOn)
    {
        _isGasOn = isGasOn;
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
    private void ChangeLanternColor()
    {
        if (_isGasOn)
        {
            light1.color = azul;
        }
        else
        {
            light1.color = vermelo;
        }
    }
    public void TryDraw()
    {
        if (_isActive && _isInWeldArea && _isMigOn && !on)
        {
            createTrail.StartTrail();
            continuousSound.Play();
            quickSound.Play();
            ParticleSystem.Play();
            on = true;
            foreach (var light in lights)
            {
                light.enabled = false;
            }
            ChangeLanternColor();
            light1.enabled = true;
            manage.Checkar();

        }
        else if (!(_isActive && _isInWeldArea && _isMigOn) && on)
        {
            createTrail.EndTrail();
            continuousSound.Pause();
            ParticleSystem.Stop();
            on = false;
            foreach (var light in lights)
            {
                light.enabled = true;
            }
            light1.enabled = false;
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
