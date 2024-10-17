using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleScript1 : MonoBehaviour
{
    private void Update()
    {
        Vector3 vector3 = Input.mousePosition;

        vector3.z = 50f;
        this.transform.position = Camera.main.ScreenToWorldPoint(vector3);
    }
}
