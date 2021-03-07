using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyncAnim : MonoBehaviour
{
    public Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (anim!=null)
        {
            anim.Play("Base Layer.Preloader Car Animation");
        }
    }
}
