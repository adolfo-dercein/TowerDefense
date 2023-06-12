using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class WaypointController : MonoBehaviour
{
    public GameObject nextWaypoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        EnemyController enemyController = other.gameObject.GetComponent<EnemyController>();
        if (nextWaypoint != null)
        {
            enemyController.direction = (nextWaypoint.transform.position - transform.position).normalized;
        } else
        {
            enemyController.direction = Vector3.forward;
        }
    }

}
