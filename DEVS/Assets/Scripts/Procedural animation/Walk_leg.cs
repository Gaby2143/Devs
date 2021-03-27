using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk_leg : MonoBehaviour
{
    public float step_distance = 1f;
    public float speed=1f;
    public float step_height = 1f;

    private Transform target;
    private Vector3 new_position;
    private Vector3 Old_position;
    private Vector3 curent_position;
    private float lerp=1;
    private void Start()
    {
        target = transform.Find("target");
        new_position = target.position;
        Old_position = new_position;
    }


    private void Update()
    {
        transform.position = curent_position;
        Ray ray = new Ray(transform.position + (transform.right * step_distance), Vector3.down);

        if (Physics.Raycast(transform.position, Vector3.down, out RaycastHit info))
        {
            if (Vector3.Distance(new_position, info.point) > step_distance)
            {
                lerp = 0;
                int direction = transform.InverseTransformPoint(info.point).z > transform.InverseTransformPoint(new_position).z ? 1 : -1;
                new_position = info.point + (transform.forward * step_distance * direction);
            }
        }

        if (lerp < 1)
        {
            Vector3 tempPosition = Vector3.Lerp(Old_position, new_position, lerp);
            tempPosition.y += Mathf.Sin(lerp * Mathf.PI) * step_height;

            curent_position = tempPosition;
            lerp += Time.deltaTime * speed;
        }
        else
        {
            Old_position = new_position;
        }
    }
}
