using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class AnimacaoPorta : MonoBehaviour
{
    private Animator animator;
    public Action<bool> setBool;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void InverterEstado()
    { 
        animator.SetBool("aberto", !animator.GetBool("aberto"));
    }
}
