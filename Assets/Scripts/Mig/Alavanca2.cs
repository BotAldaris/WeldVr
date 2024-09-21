using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alavanca2 : MonoBehaviour
{
    public Mig mig;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AnimacaoAbrirFechar>().abertoFunc = SetIsAlavanca2On;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SetIsAlavanca2On(bool isOn) { mig.SetIsLeverOn2(!isOn); }
}
