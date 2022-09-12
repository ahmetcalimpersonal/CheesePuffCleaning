using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheesePuff : MonoBehaviour
{
    private Animator animator;
    private Transform cheesePuffTarget;
    public float cleaningSpeed;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Clean(Transform target)
    {
        animator.enabled = true;
        cheesePuffTarget = target;
        Destroy(gameObject, 1f);
    }
    private void FixedUpdate()
    {
        if (animator.enabled)
        {
            transform.position = Vector3.Lerp(transform.position, cheesePuffTarget.position, Time.deltaTime * cleaningSpeed);
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(.01f,.01f,.01f), Time.deltaTime * cleaningSpeed) ;

        }
    }
}
