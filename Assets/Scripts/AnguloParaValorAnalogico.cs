using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnguloParaValorAnalogico : MonoBehaviour
{
    private int ultimoIndex;
    public Func<int, string> angValor;
    public RotatorAnalogico rotator;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        ultimoIndex =rotator.index;
    }

    // Update is called once per frame
    void Update()
    {
        if(ultimoIndex != rotator.index)
        {
            ultimoIndex  = rotator.index;
            text.text = angValor(ultimoIndex);
        }
    }
    public bool IsActive()
    {
        return 0!=ultimoIndex;
    }
}
