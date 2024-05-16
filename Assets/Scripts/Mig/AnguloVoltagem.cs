using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnguloVoltagem : MonoBehaviour
{
    public List<float> voltages = new List<float>() { 17.2f, 18.4f, 19.2f, 20f, 21.6f, 24.4f, 26f, 30.8f, 34f, 38.7f };
    public GameObject canvas;
    public Mig mig;
    void Start()
    {
        GetComponent<AnguloParaValorAnalogico>().angValor = AnguloParaVoltagem;
        canvas.SetActive(false);
    }
    private string AnguloParaVoltagem(int val)
    {
        if (val == 0)
        {
            canvas.SetActive(false);
            mig.SetIsVoltagemButtonOn(false);
            return "";
        }
        else
        {
            canvas.SetActive(true);
            mig.SetIsVoltagemButtonOn(true);

        }
        return voltages[val - 1].ToString();
    }
}
