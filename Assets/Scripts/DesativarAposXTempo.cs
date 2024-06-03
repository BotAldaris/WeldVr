using UnityEngine;

public class DesativarAposXTempo : MonoBehaviour
{
    public float timeToDeactivate = 5.0f;
    private float timer = 0.0f;
    private bool desativadoParaSempre = false;
    private bool ativo = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!desativadoParaSempre && ativo)
        {
            timer += Time.deltaTime;
            if (timer > timeToDeactivate)
            {
                desativadoParaSempre = true;
                Desaparecer();
            }
        }
    }
    public void Aparecer()
    {
        if (!desativadoParaSempre)
        {
            gameObject.SetActive(true);
            ativo = true;
        }
    }
    public void Desaparecer()
    {
        gameObject.SetActive(false);
        ativo = false;
    }
    public void Resetar()
    {
        timer = 0;
        desativadoParaSempre = false;
    }
}
