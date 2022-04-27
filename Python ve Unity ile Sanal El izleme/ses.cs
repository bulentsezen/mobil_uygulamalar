using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ses : MonoBehaviour
{
    public AudioSource Ses1;

    public void PlaySes1()
    {
        Ses1.Play();
    }

    void OnCollisionEnter()
    {
        Ses1.Play();
    }
}
