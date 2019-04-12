using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject dice1, dice2;
    // Start is called before the first frame update
    public GameObject[] waypointArray;
    private Waypoint currentWaypoint;
    private int waypointIndex = 0;
    void Start()
    {
        transform.position = new Vector3(waypointArray[waypointIndex].transform.position.x, waypointArray[waypointIndex].transform.position.y, 0);
        
    }
    
    // Update is called once per frame
    public void followWaypoints()
    {
        
    }
    void Update()
    {
        
    }
}
