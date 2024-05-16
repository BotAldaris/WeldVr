using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacaoAbrirFechar : MonoBehaviour
{
    private Animator animator;
    public bool aberto;
    public Action<bool> abertoFunc;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void InverterEstado()
    {
        bool isAnimationPlaying = animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1;
        if (!isAnimationPlaying)
        {
            aberto = !aberto;
            animator.SetBool("aberto", aberto);
            abertoFunc?.Invoke(!aberto);
        }
    }
}
