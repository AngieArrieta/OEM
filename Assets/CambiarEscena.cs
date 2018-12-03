using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour {

    public GameObject g1, g2;
    public static CambiarEscena ce;
    private void Start()
    {
       
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            g1 = GameObject.Find("Global1");
            g2 = GameObject.Find("Global2");

            Destroy(g1);
            Destroy(g2);

            SceneManager.LoadScene("SnnValue");
            SceneManager.LoadScene("OEMSCENNE");
            

        }
     
    }
}


