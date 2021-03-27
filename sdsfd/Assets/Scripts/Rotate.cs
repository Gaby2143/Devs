using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Transform pivot;
    public float speed=1f;
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            pivot.Rotate(speed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            pivot.Rotate(- speed *Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            pivot.Rotate(0, -speed * Time.deltaTime, 0);
            
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            pivot.Rotate(0, speed * Time.deltaTime, 0);
        }
    }
}
