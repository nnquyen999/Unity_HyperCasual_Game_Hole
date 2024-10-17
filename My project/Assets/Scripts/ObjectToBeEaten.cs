using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ObjectToBeEaten : MonoBehaviour
{
    public Rigidbody body;
    public bool isAllowedToTrigger;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
        body.useGravity = false;
        //cho phep tat ca cac khoi khong do khi nuot mot trong so chung
        isAllowedToTrigger = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (isAllowedToTrigger)
        {
            if (other.gameObject.tag == "Player")
            {
                body.useGravity = true;
                pointScaleHole.currentPoints += 50;
                GetComponent<ObjectToBeEaten>().isAllowedToTrigger = false;

                pointScaleHole.totalPoints += 50;

            }
        }

    }
}
