using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelClose : MonoBehaviour
{
    public GameObject Swipper;

    public void ClosePanel()
    {
        if (Swipper != null)
        {
            Swipper.SetActive(false);
        }
    }

}
