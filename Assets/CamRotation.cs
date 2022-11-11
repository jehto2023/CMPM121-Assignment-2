 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 public class CamRotation : MonoBehaviour
 {
    public float camSpeed = -0.5f;
    public float x;
    private Vector3 rotateValue;
 
    void Update()
    {
         rotateValue = new Vector3(0, x * -1, 0);
         transform.eulerAngles = transform.eulerAngles - rotateValue;
         transform.eulerAngles +=  rotateValue * camSpeed;
    }
 }