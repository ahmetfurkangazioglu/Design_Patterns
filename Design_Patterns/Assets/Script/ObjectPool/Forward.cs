using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward : MonoBehaviour
{
    void Update()
    {
        transform.position +=Vector3.forward*Time.deltaTime*2;
    }
}
