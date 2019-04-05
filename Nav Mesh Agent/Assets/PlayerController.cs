﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public NavMeshAgent meshAgent;
    public Camera cam;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray= cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                meshAgent.SetDestination(hit.point);
            } 
        }    
    }
}
