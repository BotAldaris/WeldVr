using UnityEngine;

public class TempoParaAtivarOutro : MonoBehaviour
{
    public DesativarAposXTempo outroGameObject;
    public float timeToActivate = 3.0f; // Tempo em segundos para ativar o GameObject
    private float timer = 0.0f;
    private bool ativo  = false;    

    void Update()
    {
        if (ativo)
        {
            timer += Time.deltaTime;

            if (timer >= timeToActivate)
            {
                outroGameObject.Aparecer();
            }
        }
    }

    public void Iniciar()
    {
        timer = 0.0f;               
        ativo = true;       
    }
    public void Desativar()
    {
        outroGameObject.Desaparecer();  
        ativo = false;
    }
}
