using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToMoveObject : MonoBehaviour
{
    private GameObject selectedPiece;

    private void Update()
    {
        bool isPressing = false;
        Vector3 pressPosition = Vector3.zero;

#if UNITY_ANDROID || UNITY_IOS
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
 
            pressPosition = touch.position;
            isPressing = true;
        }
#endif

        // This *will* work on mobile, but gives you the *average* touch, which
        // may not be desirable (and will not allow for multi-touch).
#if UNITY_STANDALONE || UNITY_EDITOR
        if (Input.GetMouseButton(0))
        {
            pressPosition = Input.mousePosition;
            isPressing = true;
        }
#endif

        if (isPressing)
        {
            Ray ray = Camera.main.ScreenPointToRay(pressPosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.tag == "Piece")
                {
                    selectedPiece = hit.transform.gameObject;
                }

                if (hit.collider.tag == "Plane" && selectedPiece != null)
                {
                    moveObject(hit);
                }
            }
        }
    }

    private void moveObject(RaycastHit hit)
    {
        selectedPiece.transform.position = hit.point;
    }
}
