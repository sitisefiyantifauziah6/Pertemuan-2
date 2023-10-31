using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController : MonoBehaviour
{
    public Light LampContr;

    void Start()
    {
        LampContr = GetComponent<Light>();
        LampContr.enabled = true; // Initially turn off the lamp.
    }

    public void LightUp()
    {
        LampContr.enabled = true; // Turn on the lamp when triggered.
    }
}
