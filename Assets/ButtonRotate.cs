using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRotate : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 0.25f, 0);
    }
}
