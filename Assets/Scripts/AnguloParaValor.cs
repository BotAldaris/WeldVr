using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnguloParaValor : MonoBehaviour
{
    private float ultimoAngulo;
    public TextMeshProUGUI  text;
    public Rotator rotator;
    public Func<float, string> angValor;
    // Start is called before the first frame update
    void Start()
    {
        ultimoAngulo = rotator.angulo;
    }

    // Update is called once per frame
    void Update()
    {
        if (rotator != null && ultimoAngulo != rotator.angulo)
        {
            ultimoAngulo = rotator.angulo;
            text.text = angValor(ultimoAngulo); 
        }
    }

    public bool IsActive()
    {
        return 0 != ultimoAngulo;
    }
}
