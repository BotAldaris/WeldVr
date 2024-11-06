using System;
using UnityEngine;

public class AnguloCorrenteTig : MonoBehaviour
{
    // Start is called before the first frame update
    public Tig tig;
    public string soma = "";
    void Start()
    {
        GetComponent<AnguloParaValor>().angValor = AnguloParaCorrente;

    }

    private string AnguloParaCorrente(float arg)
    {
        if (arg == 0)
        {
            tig.SetIsEletricalCurrentButtonOn(false);
            return "008";
        }
        else
        {
            tig.SetIsEletricalCurrentButtonOn(true);
        }
        var sum = -0.7058 * arg - 3.8636;
        soma = Math.Floor(sum).ToString().PadLeft(3, '0');
        return Math.Floor(sum).ToString().PadLeft(3, '0');
    }

    // Update is called once per frame
    void Update()
    {

    }
}
