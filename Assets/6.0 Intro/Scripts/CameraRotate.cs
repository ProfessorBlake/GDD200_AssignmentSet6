using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public Transform Pivot;

    // Update is called once per frame
    void Update()
    {
        Pivot.Rotate(Vector3.up, Input.GetAxis("Mouse X") * 3f);
    }
}
