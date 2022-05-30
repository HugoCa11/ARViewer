using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TapToPlaceObject : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject[] objectsToSpawn;
    public static int pieceIndex;

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
        if (!IsPointerOverUIObject())
        {
            if (isPressing)
            {
                Ray ray = Camera.main.ScreenPointToRay(pressPosition);

                if (Physics.Raycast(ray, out RaycastHit hit))
                {
                    if (hit.collider.tag == "Plane")
                    {
                        placeObject(hit);
                    }
                }
            }
        }
    }

    private void placeObject(RaycastHit hit)
    {
        //Instantiate(objectToSpawn, hit.point, Quaternion.identity);
        Instantiate(objectsToSpawn[pieceIndex], hit.point, Quaternion.identity);
    } 

    public static void selectPiece()
    {
        pieceIndex = 0;
    }

    public static void selectPiece2()
    {
        pieceIndex = 1;
    }

    private bool IsPointerOverUIObject()
    {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;
    }
}
