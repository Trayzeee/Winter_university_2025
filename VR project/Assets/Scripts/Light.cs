using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LightManager : MonoBehaviour
{

    public Light _light;
   
    void Start()
    {
        _light.intensity = 0.1f;
    }

    void Update()
    {
        
    }
}
