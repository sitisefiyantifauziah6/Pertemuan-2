using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarPanelController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Particle")) // Check if the colliding object has the "Particle" tag.
        {
            LampController lampCont = FindObjectOfType<LampController>();
            if (lampCont != null)
            {
                lampCont.LightUp();
            }
        }
    }
}
