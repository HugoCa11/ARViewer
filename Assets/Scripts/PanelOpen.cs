using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpen : MonoBehaviour
{
    public GameObject Swipper;

    public void OpenPanel()
    {
        if (Swipper!= null)
        {
            Swipper.SetActive(true);
        }
    }
}
