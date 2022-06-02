using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelClose : MonoBehaviour
{
    public GameObject Swipper;

    public void ClosePanel()
    {
        //Debug.Log("Hello Close!");
        if (Swipper != null)
        {
            TapToPlaceObject.setIndex();
            Swipper.SetActive(false);    
        }
    }

}
