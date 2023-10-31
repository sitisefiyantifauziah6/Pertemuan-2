using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotasi3D : MonoBehaviour
{
    public bool Terputar = false;
    public Vector3 KecepatanPutaran;


    // Update is called once per frame
    void Update()
    {

        if (Terputar)
        {
            transform.Rotate(
            KecepatanPutaran.x * Time.deltaTime * 10,
            KecepatanPutaran.y * Time.deltaTime * 10,
            KecepatanPutaran.z * Time.deltaTime * 10
            );
        }
        
    }

    private void OnMouseDown()
    {
        if (!Terputar)
        {
            Terputar = true;
        }
        else
        {
            Terputar = false;
        }
    }
}
