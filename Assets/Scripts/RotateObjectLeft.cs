using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateObjectLeft : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool rotateLeft = false;

    void Update()
    {
        if (rotateLeft == true)
        {
            Debug.Log("Rotate Left");
            TapToRotateObject.rotateLeft();
        }
    }

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        rotateLeft = true;
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        rotateLeft = false;
    }
}
