using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class EPIManage : MonoBehaviour
{
    public Color color0;
    public Color color1;
    public Color color2;
    public TextMeshProUGUI text;
    public DesativarAposXTempo canvas;
    private Animator animation;
    ColorAdjustments colorAdjustments;

    private void Start()
    {
        var volume = GetComponent<Volume>();
        animation = GetComponent<Animator>();
        ColorAdjustments tmp;
        if (volume.profile.TryGet<ColorAdjustments>(out tmp))
        {
            colorAdjustments = tmp;
        }
    }
    public void Checkar()
    {
        EPI[] epis = Object.FindObjectsByType<EPI>(sortMode: FindObjectsSortMode.None);
        string? menssagem = null;
        int codigo = int.MinValue;
        foreach (EPI epi in epis)
        {
            if (epi.gameObject.activeSelf == true)
            {
                if (epi.Prioridade > codigo)
                {
                    codigo = epi.Prioridade;
                    menssagem = epi.Menssagem;
                }
            }
        }
        if (menssagem != null)
        {
            switch (codigo)
            {
                case 2:
                    colorAdjustments.colorFilter.value = color0; // Extrair o valor do ColorParameter
                    break;
                case 1:
                    colorAdjustments.colorFilter.value = color1; // Extrair o valor do ColorParameter
                    break;
                case 0:
                    colorAdjustments.colorFilter.value = color2; // Extrair o valor do ColorParameter
                    break;
            }
            animation.SetTrigger("Errado");
            canvas.Resetar();
            canvas.Aparecer();
            text.text = menssagem;
        }
    }
}
