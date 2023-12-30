using System.Collections;
using System.Collections.Generic;
using UnityEngine;

void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("FishingLine"))
    {
        HookFish();
    }
}

void HookFish()
{
    MovimientoPeces.enabled = false;
}
