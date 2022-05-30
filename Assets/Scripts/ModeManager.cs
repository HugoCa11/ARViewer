using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeManager : MonoBehaviour
{
    public GameObject insert;
    public GameObject move;
    public GameObject rotate;
    public GameObject delete;
    public GameObject rotationCanvas;
    public GameObject selectionCanvas;
    public void insertMode()
    {
        Debug.Log($"Insert Mode");
        rotationCanvas.SetActive(false);
        move.SetActive(false);
        rotate.SetActive(false);
        delete.SetActive(false);
        insert.SetActive(true);
        selectionCanvas.SetActive(true);
        TapToMoveObject.SetHighlighted(false);
        TapToRotateObject.SetHighlighted(false);
    }

    public void moveMode()
    {
        Debug.Log($"Move Mode");
        selectionCanvas.SetActive(false);
        rotationCanvas.SetActive(false);
        insert.SetActive(false);
        rotate.SetActive(false);
        delete.SetActive(false);
        move.SetActive(true);
        TapToRotateObject.SetHighlighted(false);
    }

    public void rotateMode()
    {
        Debug.Log($"Rotate Mode");
        selectionCanvas.SetActive(false);
        insert.SetActive(false);
        move.SetActive(false);        
        delete.SetActive(false);
        rotate.SetActive(true);
        rotationCanvas.SetActive(true);
        TapToMoveObject.SetHighlighted(false);
    }

    public void deleteMode()
    {
        Debug.Log($"Delete Mode");
        selectionCanvas.SetActive(false);
        rotationCanvas.SetActive(false);
        insert.SetActive(false);
        move.SetActive(false);
        rotate.SetActive(false);
        delete.SetActive(true);
        TapToMoveObject.SetHighlighted(false);
        TapToRotateObject.SetHighlighted(false);
    }
}
