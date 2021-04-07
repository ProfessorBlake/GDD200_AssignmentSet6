using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeMove : MonoBehaviour
{
    public Transform Parent;
    public float LookSpeed;
    public float MoveSpeed;
    void Update()
    {
        Parent.transform.Rotate(new Vector3(0f,Input.GetAxis("Mouse X")) * LookSpeed);
        transform.Rotate(new Vector3(-Input.GetAxis("Mouse Y"), 0) * LookSpeed);
        Parent.transform.position += transform.forward * Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
        Parent.transform.position += transform.right * Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime;
    }
}
