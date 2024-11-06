using UnityEngine;

public class AlavancaTig : MonoBehaviour
{
    public LigarDeslga ligar;
    public GameObject texto;
    public BotaoSeta[] Leds;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Leds = FindObjectsByType<BotaoSeta>(sortMode: FindObjectsSortMode.None);
        ligar.func = Atualizar;
    }

    int Atualizar(bool on)
    {
        if (on)
        {
            texto.SetActive(true);
            for (int i = 0; i < Leds.Length; i++)
            {
                Leds[i].SetLigado(true);
            }
        }
        else
        {
            texto.SetActive(false);
            for (int i = 0; i < Leds.Length; i++)
            {
                Leds[i].DesligarLed();
            }
        }
        return 0;
    }
}
