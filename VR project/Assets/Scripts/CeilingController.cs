using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CeilingController : MonoBehaviour
{
    public GameObject ceiling;
    public Transform target;

    void Start()
    {
        ceiling.SetActive(true);
        
        ceiling.GetComponent<Transform>().position = new Vector3(0, 40, 0);
        ceiling.GetComponent<Transform>().localScale = new Vector3(100, 100, 1);
        transform.Rotate(new Vector3 (90, 0, 0));
    }

    void Update()
    {
        
    }
}
