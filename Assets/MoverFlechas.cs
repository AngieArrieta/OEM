using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverFlechas : MonoBehaviour {
    [SerializeField]
    float Speed = 5f;

   

    bool respuesta=true;
    Vector3 pos, localScale;


	// Use this for initialization
	void Start () {
        pos = transform.position;
        localScale = transform.localScale;
	}



    



    // Update is called once per frame
    void Update () {

        Chekear();
        if (respuesta)
            moverAbajo();
        else
             moverArriba(); 
    }

    void Chekear()
    {
        if (pos.y >  5.985f)
            respuesta = true;
        else if(pos.y < 3.485f)
            respuesta = false;

        if (((respuesta) && (localScale.y< 0)) || ((!respuesta) && (localScale.y > 0)))
            localScale.y *= -1;
        transform.localScale = localScale;  
    }

    void moverArriba()
    {
        pos += transform.up * Time.deltaTime* Speed;
        transform.position = pos + transform.forward;// *Mathf.Sin(Time.time*frecuencia)*magnitud;
        
    }
    void moverAbajo()
    {
        pos -= transform.up * Time.deltaTime* Speed;
        transform.position = pos + transform.forward;// * Mathf.Sin(Time.time * frecuencia) * magnitud;

    }

}
