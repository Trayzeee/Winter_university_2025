using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WallsManager : MonoBehaviour
{
    public List<GameObject> walls = new List<GameObject>();

    public Light _light;
   
    void Start()
    {
        foreach (var wall in walls)
        {
            wall.SetActive(true);
        }

        walls[0].GetComponent<Transform>().position = new Vector3(0, 0, 0);
        walls[0].GetComponent<Transform>().localScale = new Vector3(10, 10, 10);
        walls[1].GetComponent<Transform>().position = new Vector3(10, 10, 10);
        walls[2].GetComponent<Transform>().position = new Vector3(20, 20, 20);
        walls[3].GetComponent<Transform>().position = new Vector3(30, 30, 30);
    }

    void Update()
    {
        
    }
}
