using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandHeldController : MonoBehaviour
{
    private Vector3 lastMousePosition;
    private Vector3 deltaMousePosition;
    public float speed;
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            deltaMousePosition = (Input.mousePosition - lastMousePosition);
            transform.position += new Vector3(deltaMousePosition.normalized.x, 0f, deltaMousePosition.normalized.y) * Time.deltaTime * speed;
            lastMousePosition = Input.mousePosition;
        }
    }
}
