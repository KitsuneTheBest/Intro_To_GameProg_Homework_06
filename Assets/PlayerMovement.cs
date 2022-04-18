using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    private Camera _mainCamera;
    private NavMeshAgent _agent;
    void Start()
    {
        _mainCamera = Camera.main;
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(_mainCamera.ScreenPointToRay(Input.mousePosition), out var hit))
            {
                _agent.SetDestination(hit.point);
            }
        }
    }
}
