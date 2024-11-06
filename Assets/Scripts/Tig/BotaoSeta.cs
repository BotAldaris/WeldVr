using UnityEngine;

public class BotaoSeta : MonoBehaviour
{
    public Material materialInicial;
    public Material materialVermelho;
    public GameObject[] leds;
    public int index = 0;
    public bool ligado = false;
    public void DesligarLed()
    {
        ligado = false;
        LedsDesligados();
    }
    private void LedsDesligados()
    {
        foreach (var led in leds)
        {
            SetMaterial(led, materialInicial);
        }
    }
    public void Reiniciar()
    {
        index = 0;
        LedsDesligados();
        SetMaterial(leds[0], materialVermelho);
    }
    public void Proximo()
    {
        if (!ligado)
        {
            return;
        }
        SetMaterial(leds[index], materialInicial);
        index++;
        if (index >= leds.Length)
        {
            index = 0;
        }
        SetMaterial(leds[index], materialVermelho);
    }
    private void SetMaterial(GameObject gameObject, Material material)
    {
        var renderer = gameObject.GetComponent<Renderer>();
        if (renderer == null)
        {
            return;
        }
        Material[] materiais = renderer.materials;
        materiais[1] = material;
        renderer.materials = materiais;
    }
    public void SetLigado(bool ligado)
    {
        this.ligado = ligado;

        Reiniciar();
    }
}
