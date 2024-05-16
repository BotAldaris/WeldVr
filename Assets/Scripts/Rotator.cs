using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private bool selected;
    public bool continuo;
    private double value;
    public int anguloASerGirado;
    public int angulo = 0;
    public int AnguloMax;
    public int AnguloMin;
    private bool negative;
    private int Sinal => negative ? -1 : 1;
    private bool ativo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (selected && ativo)
        {
            if (!continuo)
            {
                ativo = false;
            }
            var novoAngulo = angulo + (negative ? 1 : -1) * anguloASerGirado;
            if(novoAngulo > AnguloMax || AnguloMin > novoAngulo)
            {
               return;
            }
                Rotate();
                angulo = novoAngulo;
        }
    }
    public void Rotate()
    {
        transform.Rotate(Sinal * anguloASerGirado, 0, 0);
    }
    public void SetSelected(bool selected)
    {
        this.selected = selected;
    }
    public void SetNegative(bool isNegative)
    {
        negative = isNegative;
    }
    public void SetActive(bool active)
    {
        ativo = active;
    }
    public double GetValue()
    {
        return value;
    }
}
