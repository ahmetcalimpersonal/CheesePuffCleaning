using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandHeldVacuumTrigger : MonoBehaviour
{
    public Transform cheesePuffTarget;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CheesePuff>())
        {
            other.GetComponent<CheesePuff>().Clean(cheesePuffTarget);
        }
    }
}
