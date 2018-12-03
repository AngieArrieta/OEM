using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPlaca : MonoBehaviour
{
    public bool pause;
    [SerializeField]
    float v = 0.01f;



    // Use this for initialization
    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "final")
        {
            Vector3 vec = new Vector3(0.16f, 4.767042f, -4.71f);
            Quaternion temp = new Quaternion(0, 0, 0, 0);
            gameObject.transform.SetPositionAndRotation(vec, temp);
        }
    }



    // Update is called once per frame
    void Update()
    {


        if (Time.timeScale == 1f)
        {
            transform.Translate(Vector3.forward * v);
        }

    }



}