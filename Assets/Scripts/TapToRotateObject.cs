using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TapToRotateObject : MonoBehaviour
{
    private static GameObject selectedPiece;
    private static float rotationSpeed = 20;

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
                    if (hit.collider.tag == "Piece")
                    {
                        if (selectedPiece != null)
                        {
                            SetHighlighted(false);
                        }
                        selectedPiece = hit.transform.gameObject;
                        SetHighlighted(true);
                    }
                    else if (hit.collider.tag != "Piece" && hit.collider.tag != "Plane")
                    {
                        selectedPiece = null;
                    }
                }
            }
        }
    }

    public static void rotateRight()
    {        
        if (selectedPiece != null)
        {
            Debug.Log($"Rotate To the Righ the Piece: {selectedPiece.transform.name}");
            selectedPiece.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
        else
        {
            Debug.Log($"Nothing to rotate");
        }
    }

    public static void rotateLeft()
    {        
        if (selectedPiece != null)
        {
            Debug.Log($"Rotate To the Left the Piece: {selectedPiece.transform.name}");
            selectedPiece.transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);
        }
        else
        {
            Debug.Log($"Nothing to rotate");
        }
    }

    private bool IsPointerOverUIObject()
    {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;
    }

    public static void SetHighlighted(bool value)
    {
        if (selectedPiece != null)
        {
            Material material = selectedPiece.GetComponent<Renderer>().material;

            material.SetColor("_EmissionColor", value ? new Color(0.5f, 0.5f, 0.5f, 1) : Color.black);
            material.EnableKeyword("_EMISSION");
        }
    }
}
