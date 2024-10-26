using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropperControls : MonoBehaviour
{
    public GameObject Building;
    public Transform dropPoint;

    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dropBuilding();
        }
    }

   
    private void dropBuilding()
    {
        GameObject _building = Instantiate(Building, dropPoint.position, dropPoint.rotation);
    }
}
