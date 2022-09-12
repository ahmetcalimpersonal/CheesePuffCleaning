using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandHeldSpinner : MonoBehaviour
{
    public float speed;
    private void FixedUpdate()
    {
        transform.localEulerAngles += new Vector3(0f, 0f, speed * Time.deltaTime);
    }
}
