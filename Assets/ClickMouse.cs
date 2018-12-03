using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickMouse : MonoBehaviour {

    public Text t1, t2, t3, t4;

    public void Start()
    {
        t1.gameObject.SetActive(false);
        t2.gameObject.SetActive(false);
        t3.gameObject.SetActive(false);
        t4.gameObject.SetActive(false);
    }
    public void Update()
    {
        OnMouseDown();
    }

    public void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            t1.gameObject.SetActive(true);
            t2.gameObject.SetActive(true);
            t3.gameObject.SetActive(true);
            t4.gameObject.SetActive(true);
        }
        else
        {
            t1.gameObject.SetActive(false);
            t2.gameObject.SetActive(false);
            t3.gameObject.SetActive(false);
            t4.gameObject.SetActive(false);
        }
    }
}
