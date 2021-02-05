using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pose : MonoBehaviour
{
    public Transform target_left_leg;
    public Transform target_right_leg;
    
    public Transform target_left;
    public Transform target_right;

    public float distance=0.1f;

    private Vector3 target_pos_left;
    private Vector3 target_pos_right;

    private Vector3 initial_pos_riight;
    private Vector3 initial_pos_left;

    private bool left;

    void Start()
    {
        initial_pos_left = target_left_leg.position;
        initial_pos_riight = target_right_leg.position;
    }

    // Update is called once per frame
    void Update()
    {
        target_left_leg.position = initial_pos_left;
        target_right_leg.position = initial_pos_riight;
       
        RaycastHit hit_left;
        RaycastHit hit_right;
        if(Physics.Raycast(target_left.position,Vector3.down,out hit_left))
        {
            target_pos_left = hit_left.point;
        }

        if(Physics.Raycast(target_right.position,Vector3.down,out hit_right))
        {
            target_pos_right = hit_right.point;
        }

        if(Vector3.Distance(target_pos_left,target_left_leg.position)>distance)
        {
            target_left_leg.position = target_pos_left;
            initial_pos_left = target_left_leg.position;
        }

        if(Vector3.Distance(target_pos_right,target_right_leg.position)>distance)
        {
            target_right_leg.position = target_pos_right;
            initial_pos_riight = target_right_leg.position;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(target_left_leg.position, 0.2f);
        Gizmos.DrawWireSphere(target_right_leg.position, 0.2f);
        Gizmos.DrawSphere(target_pos_left, 0.1f);
        Gizmos.DrawSphere(target_pos_right, 0.1f);
    }
}
