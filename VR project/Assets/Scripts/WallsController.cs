using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WallsController : MonoBehaviour
{
    public List<GameObject> walls = new List<GameObject>();
   
    void Start()
    {
        foreach (var wall in walls)
        {
            wall.SetActive(true);
        }

        walls[0].GetComponent<Transform>().position = new Vector3(45, 20, 45);
        walls[0].GetComponent<Transform>().localScale = new Vector3(10, 40, 10);
                
        walls[1].GetComponent<Transform>().position = new Vector3(-45, 20, -45);
        walls[1].GetComponent<Transform>().localScale = new Vector3(10, 40, 10);

        walls[2].GetComponent<Transform>().position = new Vector3(45, 20, -45);
        walls[2].GetComponent<Transform>().localScale = new Vector3(10, 40, 10);

        walls[3].GetComponent<Transform>().position = new Vector3(-45, 20, 45);
        walls[3].GetComponent<Transform>().localScale = new Vector3(10, 40, 10);

    }

    void Update()
    {
        
    }
}
