using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateObjectRight : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool rotateRight = false;

    void Update()
    {
        if (rotateRight == true)
        {
            Debug.Log("Rotate Right");
            TapToRotateObject.rotateRight();
        }
    }

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        rotateRight = true;
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        rotateRight = false;
    }
}
