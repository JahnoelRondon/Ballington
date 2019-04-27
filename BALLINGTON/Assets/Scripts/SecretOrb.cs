using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretOrb : MonoBehaviour
{
    [SerializeField] GameObject _AgniOrb;


    public void StoleOrb()
    {
        _AgniOrb.SetActive(false);
    }
}
