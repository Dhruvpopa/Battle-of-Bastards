using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<WayPoint> path = new List<WayPoint>();
    [SerializeField] float waitTime = 1.0f;
    
    void Start()
    {
        StartCoroutine(FollowPath());
    }

    IEnumerator FollowPath()
    {
        foreach (WayPoint wayPoint in path)
        {
            transform.position = wayPoint.transform.position;

            yield return new WaitForSeconds(waitTime);
        }
    }
}
