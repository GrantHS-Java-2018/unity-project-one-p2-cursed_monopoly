using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public Waypoint[] myPoints;
    private float speed = 3f;
    private Waypoint currentWaypoint;
    private int currentIndex = 0;
    private bool waiting = false;
    

    public Waypoint previous { get; set; }

    public float distance { get; set; }

    void Start()
    {
        // if (wayPoints.length > 0)
        // {
        //    currentWaypoint = wayPoints[0];
        // }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

