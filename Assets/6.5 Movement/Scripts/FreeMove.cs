using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeMove : MonoBehaviour
{
    public Transform Parent;
    void Update()
    {
        Parent.transform.Rotate(new Vector3(0f,Input.GetAxis("Mouse X")) * 5f);
        transform.Rotate(new Vector3(-Input.GetAxis("Mouse Y"), 0) * 5f);
        Parent.transform.position += transform.forward * Input.GetAxis("Vertical");
        Parent.transform.position += transform.right * Input.GetAxis("Horizontal");
    }
}
