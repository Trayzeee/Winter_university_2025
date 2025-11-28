using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Floor : MonoBehaviour
{
    public GameObject floor;
    public Transform target;
    void Start()
    {
        floor.SetActive(true);

        transform.GetComponent<Transform>().position = new Vector3(0, 0, 0);
        transform.GetComponent<Transform>().localScale = new Vector3(100, 100, 1);
        transform.Rotate(new Vector3 (90, 0, 0));
    }

    void Update()
    {
        
    }
}
