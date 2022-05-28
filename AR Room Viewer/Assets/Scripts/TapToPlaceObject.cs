using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToPlaceObject : MonoBehaviour
{
    public GameObject objectToSpawn;
    private GameObject spawnedObject;
    private Vector2 touchPos;
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
                if(hit.collider.tag == "Plane" && selectedPiece == null)
                {
                    placeObject(hit);
                }
                else if (hit.collider.name == "Cube(Clone)")
                {
                    Debug.Log($"Name: {hit.collider.name}");
                    Debug.Log($"Name: {hit.collider.transform.position}");
                    selectedPiece = hit.transform.gameObject;
                }
                else if (hit.collider.tag == "Plane" && selectedPiece != null)
                {
                    selectedPiece.transform.position = hit.point;
                    selectedPiece = null;
                }

                /*if (spawnedObject == null)
                {
                    spawnedObject = Instantiate(objectToSpawn, hit.point, Quaternion.identity);
                }
                else if (hit.collider.tag == "Plane")
                {
                    spawnedObject.transform.position = hit.point;
                }*/

            }
        }
    }

    private void placeObject(RaycastHit hit)
    {
        spawnedObject = Instantiate(objectToSpawn, hit.point, Quaternion.identity);
    } 
}
