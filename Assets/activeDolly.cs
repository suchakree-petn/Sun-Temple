using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeDolly : MonoBehaviour
{
    public GameObject Dolly;
    public void Active(){
        Dolly.SetActive(true);
    }
}
