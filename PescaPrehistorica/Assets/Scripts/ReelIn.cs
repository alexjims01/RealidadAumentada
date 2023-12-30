using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReelInController : MonoBehaviour
{
    public float reelSpeed = 5f;
    public float maxTension = 50f;
    public Transform fishingRodTip;
    public Rigidbody rodRigidbody; 
    public GameObject fish; 
    private bool isFishHooked = false;

    void Update()
    {
        if (!isFishHooked)
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                ReelIn();
            }
        }
    }

    void ReelIn()
    {
        Vector3 reelDirection = (fishingRodTip.position - transform.position).normalized;
        rodRigidbody.AddForce(reelDirection * reelSpeed, ForceMode.Impulse);

        CheckTension();
    }

    void CheckTension()
    {
        float tension = CalculateTension(); 

        if (tension >= maxTension && !isFishHooked)
        {
            HookFish();
        }
    }

    void HookFish()
    {
        isFishHooked = true;
    }

    float CalculateTension()
    {
        float distance = Vector3.Distance(fishingRodTip.position, fish.transform.position);
        return distance;
    }
}
