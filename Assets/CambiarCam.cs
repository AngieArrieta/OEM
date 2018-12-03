using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarCam : MonoBehaviour {
public Camera Camara1 ;
public Camera Camara2;
 public Camera Camara3;
 public Camera Camara4;

    public GameObject g1, g2, g3, g4;

    // Use this for initialization
    void Start () {
        Camara1.gameObject.SetActive(false);
        Camara2.gameObject.SetActive(true);
        Camara3.gameObject.SetActive(false);
        Camara4.gameObject.SetActive(false);
    
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("m"))
        {
            g1 = GameObject.Find("Global1");
            g2 = GameObject.Find("Global2");
            g3 = GameObject.Find("Global3");
            g4 = GameObject.Find("Global4");

            Destroy(g1);
            Destroy(g2);
            Destroy(g3);
            Destroy(g4);
            SceneManager.LoadScene("SnnValue");
        }
        if (Input.GetKeyDown("1"))
        {
            Camara1.gameObject.SetActive(false);
            Camara2.gameObject.SetActive(true);
            Camara3.gameObject.SetActive(false);
            Camara4.gameObject.SetActive(false);
 
        }
        if (Input.GetKeyDown("2"))
        {
            Camara1.gameObject.SetActive(true);
            Camara2.gameObject.SetActive(false);
            Camara3.gameObject.SetActive(false);
            Camara4.gameObject.SetActive(false);

        }
        if (Input.GetKeyDown("3"))
        {
            Camara3.gameObject.SetActive(true);
            Camara2.gameObject.SetActive(false);
            Camara4.gameObject.SetActive(false);
            Camara1.gameObject.SetActive(false);
    
        }
        if (Input.GetKeyDown("4"))
        {
            Camara4.gameObject.SetActive(true);
            Camara2.gameObject.SetActive(false);
            Camara3.gameObject.SetActive(false);
            Camara1.gameObject.SetActive(false);
            
        }
       


    }
}
