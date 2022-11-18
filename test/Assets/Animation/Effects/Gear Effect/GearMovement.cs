using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearMovement : MonoBehaviour
{
    public GameObject GearIcon;

    float rotation = 0.15f;

    // Update is called once per frame
    void Update()
    {
        GearIcon.transform.Rotate(0,0, rotation);
    }
}
