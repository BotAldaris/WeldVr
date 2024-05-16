using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alavanca1 : MonoBehaviour
{
    public Mig mig;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AnimacaoAbrirFechar>().abertoFunc = SetIsAlavanca1On;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void SetIsAlavanca1On(bool isOn) { mig.SetIsLeverOn1(isOn); }
}
