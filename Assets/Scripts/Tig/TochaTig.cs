using System.Collections;
using UnityEngine;

public class TochaTig : MonoBehaviour
{
    public CreateTrail createTrail;
    public bool _isActive = false;
    public bool _isInWeldArea = true;
    private bool _isInMaterialArea = false;
    public bool _isMigOn = false;
    public bool on;
    private PlayContinuousSound continuousSound;
    private PlayQuickSound quickSound;
    private Light[] lights;
    public Light light1;
    private Color azul;
    private bool _isGasOn = false;
    public Color vermelo;
    private Coroutine ambientLightCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        lights = FindObjectsByType<Light>(sortMode: FindObjectsSortMode.None);
        continuousSound = GetComponent<PlayContinuousSound>();
        quickSound = GetComponent<PlayQuickSound>();
        azul = light1.color;
        RenderSettings.ambientLight = Color.gray;

        // Remove o skybox
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
    public void SetIsInMaterialArea(bool isInMaterialArea)
    {
        _isInMaterialArea = isInMaterialArea;
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
        if (_isActive && _isInWeldArea && _isInMaterialArea && _isMigOn && !on)
        {
            createTrail.StartTrail();
            continuousSound.Play();
            quickSound.Play();
            on = true;
            foreach (var light in lights)
            {
                light.enabled = false;
            }
            if (ambientLightCoroutine != null)
            {
                StopCoroutine(ambientLightCoroutine);
                ambientLightCoroutine = null;
            }
            RenderSettings.ambientLight = Color.black;
            ChangeLanternColor();
            light1.enabled = true;

        }
        else if (!(_isActive && _isInWeldArea && _isInMaterialArea && _isMigOn) && on)
        {
            createTrail.EndTrail();
            continuousSound.Pause();
            on = false;
            foreach (var light in lights)
            {
                light.enabled = true;
            }
            if (ambientLightCoroutine != null)
            {
                StopCoroutine(ambientLightCoroutine);
                ambientLightCoroutine = null;
            }
            ambientLightCoroutine = StartCoroutine(DelayedAmbientLightChange(2f));
            light1.enabled = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Area Solda"))
        {
            SetIsInWeldArea(true);
        }
        else if (other.gameObject.CompareTag("Palito"))
        {
            SetIsInMaterialArea(true);
            other.gameObject.transform.position += Vector3.up * 1f;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Area Solda"))
        {
            SetIsInWeldArea(false);
        }
        else if (other.gameObject.CompareTag("Palito"))
        {
            SetIsInMaterialArea(false);
        }
    }

    private IEnumerator DelayedAmbientLightChange(float delay)
    {
        yield return new WaitForSeconds(delay);
        RenderSettings.ambientLight = Color.gray;
    }
}
