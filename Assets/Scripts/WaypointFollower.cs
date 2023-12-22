using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WaypointFollower : MonoBehaviour
{
    GameObject player;
    Vector3 lastPlayerPos;

    [SerializeField] GameObject[] waypoints;
    int currentWaypointIndex = 0;
    [SerializeField] float speed = 1f;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
    void Update()
    {
        if (lastPlayerPos != player.transform.position)
        {
            Debug.Log(player.transform.position);
            lastPlayerPos = player.transform.position;

        }
        
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
}