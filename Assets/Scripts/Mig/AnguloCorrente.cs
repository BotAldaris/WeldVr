using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class AnguloCorrente : MonoBehaviour
{
    // Start is called before the first frame update
    public Mig mig;

    void Start()
    {
       GetComponent<AnguloParaValor>().angValor = AnguloParaCorrente;

    }

    private string AnguloParaCorrente(float arg)
    { 
        if (arg == 0)
        {
            mig.SetIsEletricalCurrentButtonOn(false);
        }
        else
        {
            mig.SetIsEletricalCurrentButtonOn(true);
        }
        var sum = 0.8941*arg + 20.231;
        return sum.ToString()[..3];
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
