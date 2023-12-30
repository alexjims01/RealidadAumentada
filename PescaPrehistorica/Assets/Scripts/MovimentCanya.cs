using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentCanya : MonoBehaviour
{
    public Rigidbody rodRigidbody;
    public float castingForce = 10f;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            CastRod();
        }
    }

    void CastRod()
    { 
        if (!rodRigidbody.IsSleeping())
            return;

        rodRigidbody.AddForce(transform.forward * castingForce, ForceMode.Impulse);
    }
}
