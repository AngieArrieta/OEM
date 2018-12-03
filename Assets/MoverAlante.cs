using UnityEngine;
using System.Collections;

public class MoverAlante : MonoBehaviour {
    [SerializeField]
    float Speed = 3f;



    bool respuesta = true;
    Vector3 pos, localScale;


    // Use this for initialization
    void Start()
    {
        pos = transform.position;
        localScale = transform.localScale;
    }







    // Update is called once per frame
    void Update()
    {

        Chekear();
        if (respuesta)
          moverAbajo();
        else
              moverArriba();
    }

    void Chekear()
    {
        if (pos.x > 1.392958f)
            respuesta = true;
        else if (pos.x < -1.057958f)
            respuesta = false;

        if (((respuesta) && (localScale.x < 0)) || ((!respuesta) && (localScale.x > 0)))
            localScale.x *= -1;
        transform.localScale = localScale;
    }

    void moverArriba()
    {
        pos += transform.right * Time.deltaTime * Speed;
        transform.position = pos + transform.forward;// *Mathf.Sin(Time.time*frecuencia)*magnitud;

    }
    void moverAbajo()
    {
        pos -= transform.right * Time.deltaTime * Speed;
        transform.position = pos + transform.forward;// * Mathf.Sin(Time.time * frecuencia) * magnitud;

    }
}
