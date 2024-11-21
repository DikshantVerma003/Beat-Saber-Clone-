using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * 3;
    }
}
