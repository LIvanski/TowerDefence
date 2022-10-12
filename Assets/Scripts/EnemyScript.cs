using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed = 20f;
    private Transform target;
    private int wavepointsIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        target = WayPoints.points[0];
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        //if(Vector3.Distance(transform.position, target.position) <= 0.4f){
        if (dir.magnitude <= speed * Time.deltaTime) { 
            GetNextWayPoint();
        }
    }

    void GetNextWayPoint(){
        if(wavepointsIndex >= WayPoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        wavepointsIndex++;
        target = WayPoints.points[wavepointsIndex];
    }

    private void OnDestroy()
    {
        WaveSpawner.enemys.Remove(transform);
    }

}
