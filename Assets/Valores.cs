using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Valores : MonoBehaviour {

    BtnIniciar b1,b2;
    VariablesGlobales t1, t2;
    public GameObject g1, g2;

    public Text textE,tt1,tt2;
    public Text textB;
    public Text textL;
    public Text textK;
    Vector3 pos;
    public GameObject placa;

    int paso;
    float Tf1, Tf2;
    float l, f;
    string prueba;
    float[] xv = new float[33];
    float[] ve = new float[33];
    float[] vb = new float[33];

    float tp1, tp2;
    // Use this for initialization

    void Start() {

        g1 = GameObject.Find("Global1");
        g2 = GameObject.Find("Global2");

        t1 = g1.GetComponent<VariablesGlobales>();
        t2 = g2.GetComponent<VariablesGlobales>();
        
        Tf1 = float.Parse(t1.t.text);
        Tf2 = float.Parse(t2.t.text);

        Debug.Log(Tf1);
        
        l = ecuacionLong();
        f = Tf2;

        float k = ecuacionK(l);
        for (int i = 0; i < 33; i++)
        {
            xv[i] = ecuacionX(l, i + 1);
            ve[i] = ecuacionE(xv[i],Tf1,Tf2);
            vb[i] = ecuacionB(ve[i]);
        }

        textL.text = "λ = " + l.ToString() + " m";
        textK.text = "K = " + k.ToString() + " rad/m";

    }

    float ecuacionX(float l, int paso)
    {
        return (paso * l) / 33;
    }

    float ecuacionE(float x,float a,float f)
    {
        int t = 0, c = 300000000;
        return (a * Mathf.Sin((((2 * Mathf.PI * f) / c) * x) - (2 * Mathf.PI * f * t)));
    }
    float ecuacionB(float E)
    {
        int c = 300000000;
        return E / c;
    }
    float ecuacionLong()
    {
        int c = 300000000;
        return c / Tf2;
    }
    float ecuacionK(float longitud)
    {
        return (2 * Mathf.PI) / longitud;
    }



    void Update()
    {
        pos = placa.transform.position;

        if (pos.z >= -3.690001f && pos.z <= -3.510001f)
        {

            textE.text = "E = " + ve[11].ToString() + " v/m";
            textB.text = "B = " + vb[11].ToString() + " v/m";

        }
        else if (pos.z >= -3.510001f && pos.z <= -3.390001f)
        {
            textE.text = "E = " + ve[11].ToString() + " v/m";
            textB.text = "B = " + vb[11].ToString() + " v/m";
        }
        else if (pos.z >= -3.390001f && pos.z <= -3.270001f)
        {
            textE.text = "E = " + ve[12].ToString() + " v/m";
            textB.text = "B = " + vb[12].ToString() + " v/m";
        }
        else if (pos.z >= -3.270001f && pos.z <= -3.150002f)
        {
            textE.text = "E = " + ve[12].ToString() + " v/m";
            textB.text = "B = " + vb[12].ToString() + " v/m";
        }
        else if (pos.z >= -3.150002f && pos.z <= -3.030002f)
        {
            textE.text = "E = " + ve[13].ToString() + " v/m";
            textB.text = "B = " + vb[13].ToString() + " v/m";
        }
        else if (pos.z >= -3.030002f && pos.z <= -2.930002f)
        {
            textE.text = "E = " + ve[13].ToString() + " v/m";
            textB.text = "B = " + vb[13].ToString() + " v/m";
        }
        else if (pos.z >= -2.930002f && pos.z <= -2.790002f)
        {
            textE.text = "E = " + ve[14].ToString() + " v/m";
            textB.text = "B = " + vb[14].ToString() + " v/m";
        }
        else if (pos.z >= -2.790002f && pos.z <= -2.670002f)
        {
            textE.text = "E = " + ve[14].ToString() + " v/m";
            textB.text = "B = " + vb[14].ToString() + " v/m";
        }
        else if (pos.z >= -2.670002f && pos.z <= -2.530002f)
        {
            textE.text = "E = " + ve[15].ToString() + " v/m";
            textB.text = "B = " + vb[15].ToString() + " v/m";
        }
        else if (pos.z >= -2.530002f && pos.z <= -2.410002f)
        {
            textE.text = "E = " + ve[15].ToString() + " v/m";
            textB.text = "B = " + vb[15].ToString() + " v/m";
        }




        else if (pos.z >= -2.410002f && pos.z <= -2.290002f)
        {
            textE.text = "E = " + ve[16].ToString() + " v/m";
            textB.text = "B = " + vb[16].ToString() + " v/m";
        }
        else if (pos.z >= -2.290002f && pos.z <= -2.170002f)
        {
            textE.text = "E = " + ve[16].ToString() + " v/m";
            textB.text = "B = " + vb[16].ToString() + " v/m";
        }
        else if (pos.z >= -2.170002f && pos.z <= -2.050003f)
        {
            textE.text = "E = " + ve[16].ToString() + " v/m";
            textB.text = "B = " + vb[16].ToString() + " v/m";
        }
        else if (pos.z >= -2.050003f && pos.z <= -1.930003f)
        {
            textE.text = "E = " + ve[17].ToString() + " v/m";
            textB.text = "B = " + vb[17].ToString() + " v/m";
        }
        else if (pos.z >= -1.930003f && pos.z <= -1.790003f)
        {
            textE.text = "E = " + ve[17].ToString() + " v/m";
            textB.text = "B = " + vb[17].ToString() + " v/m";
        }
        else if (pos.z >= -1.790003f && pos.z <= -1.670003f)
        {
            textE.text = "E = " + ve[18].ToString() + " v/m";
            textB.text = "B = " + vb[18].ToString() + " v/m";
        }
        else if (pos.z >= -1.670003f && pos.z <= -1.570003f)
        {
            textE.text = "E = " + ve[18].ToString() + " v/m";
            textB.text = "B = " + vb[18].ToString() + " v/m";
        }
        else if (pos.z >= -1.570003f && pos.z <= -1.410003f)
        {
            textE.text = "E = " + ve[19].ToString() + " v/m";
            textB.text = "B = " + vb[19].ToString() + " v/m";
        }
        else if (pos.z >= -1.410003f && pos.z <= -1.290003f)
        {
            textE.text = "E = " + ve[19].ToString() + " v/m";
            textB.text = "B = " + vb[19].ToString() + " v/m";
        }
        else if (pos.z >= -1.290003f && pos.z <= -1.170003f)
        {
            textE.text = "E = " + ve[20].ToString() + " v/m";
            textB.text = "B = " + vb[20].ToString() + " v/m";
        }




        else if (pos.z >= -1.170003f && pos.z <= -1.050004f)
        {
            textE.text = "E = " + ve[20].ToString() + " v/m";
            textB.text = "B = " + vb[20].ToString() + " v/m";
        }
        else if (pos.z >= -1.050004f && pos.z <= -0.8900037f)
        {
            textE.text = "E = " + ve[20].ToString() + " v/m";
            textB.text = "B = " + vb[20].ToString() + " v/m";
        }
        else if (pos.z >= -0.8900037f && pos.z <= -0.8100038f)
        {
            textE.text = "E = " + ve[21].ToString() + " v/m";
            textB.text = "B = " + vb[21].ToString() + " v/m";
        }
        else if (pos.z >= -0.8100038f && pos.z <= -0.6900039f)
        {
            textE.text = "E = " + ve[21].ToString() + " v/m";
            textB.text = "B = " + vb[21].ToString() + " v/m";
        }
        else if (pos.z >= -0.6900039f && pos.z <= -0.550004f)
        {
            textE.text = "E = " + ve[22].ToString() + " v/m";
            textB.text = "B = " + vb[22].ToString() + " v/m";
        }
        else if (pos.z >= -0.550004f && pos.z <= -0.430004f)
        {
            textE.text = "E = " + ve[22].ToString() + " v/m";
            textB.text = "B = " + vb[22].ToString() + " v/m";
        }
        else if (pos.z >= -0.430004f && pos.z <= -0.2900039f)
        {
            textE.text = "E = " + ve[22].ToString() + " v/m";
            textB.text = "B = " + vb[22].ToString() + " v/m";
        }
        else if (pos.z >= -0.2900039f && pos.z <= -0.1900039f)
        {
            textE.text = "E = " + ve[23].ToString() + " v/m";
            textB.text = "B = " + vb[23].ToString() + " v/m";
        }
        else if (pos.z >= -0.1900039f && pos.z <= -0.05000394f)
        {
            textE.text = "E = " + ve[23].ToString() + " v/m";
            textB.text = "B = " + vb[23].ToString() + " v/m";
        }
        else if (pos.z >= -0.05000394f && pos.z <= 0.08999605f)
        {
            textE.text = "E = " + ve[24].ToString() + " v/m";
            textB.text = "B = " + vb[24].ToString() + " v/m";
        }





        else if (pos.z >= 0.08999605f && pos.z <= 0.209996f)
        {
            textE.text = "E = " + ve[24].ToString() + " v/m";
            textB.text = "B = " + vb[24].ToString() + " v/m";
        }
        else if (pos.z >= 0.209996f && pos.z <= 0.3499961f)
        {
            textE.text = "E = " + ve[24].ToString() + " v/m";
            textB.text = "B = " + vb[24].ToString() + " v/m";
        }
        else if (pos.z >= 0.3499961f && pos.z <= 0.4499961f)
        {
            textE.text = "E = " + ve[25].ToString() + " v/m";
            textB.text = "B = " + vb[25].ToString() + " v/m";
        }
        else if (pos.z >= 0.4499961f && pos.z <= 0.5899961f)
        {
            textE.text = "E = " + ve[25].ToString() + " v/m";
            textB.text = "B = " + vb[25].ToString() + " v/m";
        }
        else if (pos.z >= 0.5899961f && pos.z <= 0.709996f)
        {
            textE.text = "E = " + ve[26].ToString() + " v/m";
            textB.text = "B = " + vb[26].ToString() + " v/m";
        }

        else if (pos.z >= 0.709996f && pos.z <= 0.8299959f)
        {
            textE.text = "E = " + ve[26].ToString() + " v/m";
            textB.text = "B = " + vb[26].ToString() + " v/m";
        }
        else if (pos.z >= 0.8299959f && pos.z <= 0.9499958f)
        {
            textE.text = "E = " + ve[27].ToString() + " v/m";
            textB.text = "B = " + vb[27].ToString() + " v/m";
        }
        else if (pos.z >= 0.9499958f && pos.z <= 1.089996f)
        {
            textE.text = "E = " + ve[27].ToString() + " v/m";
            textB.text = "B = " + vb[27].ToString() + " v/m";
        }
        else if (pos.z >= 1.089996f && pos.z <= 1.209996f)
        {
            textE.text = "E = " + ve[27].ToString() + " v/m";
            textB.text = "B = " + vb[27].ToString() + " v/m";

        }
        else if (pos.z >= 1.209996f && pos.z <= 1.329995f)
        {
            textE.text = "E = " + ve[28].ToString() + " v/m";
            textB.text = "B = " + vb[28].ToString() + " v/m";
        }







        else if (pos.z >= 1.329995f && pos.z <= 1.469995f)
        {
            textE.text = "E = " + ve[28].ToString() + " v/m";
            textB.text = "B = " + vb[28].ToString() + " v/m";
        }
        else if (pos.z >= 1.469995f && pos.z <= 1.589995f)
        {
            textE.text = "E = " + ve[29].ToString() + " v/m";
            textB.text = "B = " + vb[29].ToString() + " v/m";
        }
        else if (pos.z >= 1.589995f && pos.z <= 1.709995f)
        {
            textE.text = "E = " + ve[30].ToString() + " v/m";
            textB.text = "B = " + vb[30].ToString() + " v/m";
        }
        else if (pos.z >= 1.709995f && pos.z <= 1.829995f)
        {
            textE.text = "E = " + ve[30].ToString() + " v/m";
            textB.text = "B = " + vb[30].ToString() + " v/m";
        }
        else if (pos.z >= 1.829995f && pos.z <= 1.949995f)
        {
            textE.text = "E = " + ve[31].ToString() + " v/m";
            textB.text = "B = " + vb[31].ToString() + " v/m";
        }
        else if (pos.z >= 1.949995f && pos.z <= 2.069995f)
        {
            textE.text = "E = " + ve[31].ToString() + " v/m";
            textB.text = "B = " + vb[31].ToString() + " v/m";
        }
        else if (pos.z >= 2.069995f && pos.z <= 2.189995f)
        {
            textE.text = "E = " + ve[32].ToString() + " v/m";
            textB.text = "B = " + vb[32].ToString() + " v/m";
        }
        else if (pos.z >= 2.189995f && pos.z <= 2.329994f)
        {
            textE.text = "E = " + ve[32].ToString() + " v/m";
            textB.text = "B = " + vb[32].ToString() + " v/m";
        }
        else if (pos.z >= 2.329994f && pos.z <= 2.429994f)
        {
            textE.text = "E = " + ve[32].ToString() + " v/m";
            textB.text = "B = " + vb[32].ToString() + " v/m";
        }
        else if (pos.z >= 2.429994f && pos.z <= 2.589994f)
        {
            textE.text = "E = " + ve[1].ToString() + " v/m";
            textB.text = "B = " + vb[1].ToString() + " v/m";

        }





        else if (pos.z >= 2.589994f && pos.z <= 2.729994f)
        {
            textE.text = "E = " + ve[1].ToString() + " v/m";
            textB.text = "B = " + vb[1].ToString() + " v/m";
        }
        else if (pos.z >= 2.729994f && pos.z <= 2.829994f)
        {
            textE.text = "E = " + ve[2].ToString() + " v/m";
            textB.text = "B = " + vb[2].ToString() + " v/m";
        }
        else if (pos.z >= 2.969994f && pos.z <= 3.109994f)
        {
            textE.text = "E = " + ve[2].ToString() + " v/m";
            textB.text = "B = " + vb[2].ToString() + " v/m";
        }
        else if (pos.z >= 3.109994f && pos.z <= 3.209994f)
        {
            textE.text = "E = " + ve[3].ToString() + " v/m";
            textB.text = "B = " + vb[3].ToString() + " v/m";
        }
        else if (pos.z >= 3.209994f && pos.z <= 3.349993f)
        {
            textE.text = "E = " + ve[3].ToString() + " v/m";
            textB.text = "B = " + vb[3].ToString() + " v/m";
        }
        else if (pos.z >= 3.349993f && pos.z <= 3.469993f)
        {
            textE.text = "E = " + ve[3].ToString() + " v/m";
            textB.text = "B = " + vb[3].ToString() + " v/m";
        }
        else if (pos.z >= 3.469993f && pos.z <= 3.589993f)
        {
            textE.text = "E = " + ve[4].ToString() + " v/m";
            textB.text = "B = " + vb[4].ToString() + " v/m";
        }
        else if (pos.z >= 3.589993f && pos.z <= 3.729993f)
        {
            textE.text = "E = " + ve[4].ToString() + " v/m";
            textB.text = "B = " + vb[4].ToString() + " v/m";
        }
        else if (pos.z >= 3.729993f && pos.z <= 3.849993f)
        {
            textE.text = "E = " + ve[5].ToString() + " v/m";
            textB.text = "B = " + vb[5].ToString() + " v/m";
        }
        else if (pos.z >= 3.849993f && pos.z <= 3.989993f)
        {
            textE.text = "E = " + ve[5].ToString() + " v/m";
            textB.text = "B = " + vb[5].ToString() + " v/m";
        }




        else if (pos.z >= 3.989993f && pos.z <= 4.089991f)
        {
            textE.text = "E = " + ve[6].ToString() + " v/m";
            textB.text = "B = " + vb[6].ToString() + " v/m";

        }
        else if (pos.z >= 4.089991f && pos.z <= 4.209988f)
        {
            textE.text = "E = " + ve[6].ToString() + " v/m";
            textB.text = "B = " + vb[6].ToString() + " v/m";
        }
        else if (pos.z >= 4.209988f && pos.z <= 4.329985f)
        {
            textE.text = "E = " + ve[7].ToString() + " v/m";
            textB.text = "B = " + vb[7].ToString() + " v/m";
        }
        else if (pos.z >= 4.329985f && pos.z <= 4.429983f)
        {
            textE.text = "E = " + ve[7].ToString() + " v/m";
            textB.text = "B = " + vb[7].ToString() + " v/m";
        }
        else if (pos.z >= 4.429983f && pos.z <= 4.54998f)
        {
            textE.text = "E = " + ve[8].ToString() + " v/m";
            textB.text = "B = " + vb[8].ToString() + " v/m";
        }
        else if (pos.z >= 4.54998f && pos.z <= 4.709976f)
        {
            textE.text = "E = " + ve[8].ToString() + " v/m";
            textB.text = "B = " + vb[8].ToString() + " v/m";
        }
        else if (pos.z >= 4.709976f && pos.z <= 4.829973f)
        {
            textE.text = "E = " + ve[8].ToString() + " v/m";
            textB.text = "B = " + vb[8].ToString() + " v/m";
        }
        else if (pos.z >= 4.829973f && pos.z <= 4.969969f)
        {
            textE.text = "E = " + ve[9].ToString() + " v/m";
            textB.text = "B = " + vb[9].ToString() + " v/m";
        }
        else if (pos.z >= 4.969969f && pos.z <= 5.089966f)
        {
            textE.text = "E = " + ve[9].ToString() + " v/m";
            textB.text = "B = " + vb[9].ToString() + " v/m";
        }
        else if (pos.z >= 5.089966f && pos.z <= 5.209963f)
        {
            textE.text = "E = " + ve[10].ToString() + " v/m";
            textB.text = "B = " + vb[10].ToString() + " v/m";
        }





        else if (pos.z >= 5.209963f && pos.z <= 5.32996f)
        {
            textE.text = "E = " + ve[10].ToString() + " v/m";
            textB.text = "B = " + vb[10].ToString() + " v/m";
        }
        else if (pos.z >= 5.32996f && pos.z <= 5.469957f)
        {
            textE.text = "E = " + ve[11].ToString() + " v/m";
            textB.text = "B = " + vb[11].ToString() + " v/m";

        }
        else if (pos.z >= 5.469957f && pos.z <= 5.589954f)
        {
            textE.text = "E = " + ve[11].ToString() + " v/m";
            textB.text = "B = " + vb[11].ToString() + " v/m";
        }
        else if (pos.z >= 5.589954f && pos.z <= 5.72995f)
        {
            textE.text = "E = " + ve[11].ToString() + " v/m";
            textB.text = "B = " + vb[11].ToString() + " v/m";
        }
        else if (pos.z >= 5.72995f && pos.z <= 5.849947f)
        {
            textE.text = "E = " + ve[12].ToString() + " v/m";
            textB.text = "B = " + vb[12].ToString() + " v/m";
        }
        else if (pos.z >= 5.849947f && pos.z <= 5.969944f)
        {
            textE.text = "E = " + ve[12].ToString() + " v/m";
            textB.text = "B = " + vb[12].ToString() + " v/m";
        }
        else if (pos.z >= 5.969944f && pos.z <= 6.109941f)
        {
            textE.text = "E = " + ve[13].ToString() + " v/m";
            textB.text = "B = " + vb[13].ToString() + " v/m";
        }
        else if (pos.z >= 6.109941f && pos.z <= 6.209939f)
        {
            textE.text = "E = " + ve[13].ToString() + " v/m";
            textB.text = "B = " + vb[13].ToString() + " v/m";
        }
        else if (pos.z >= 6.209939f && pos.z <= 6.369935f)
        {
            textE.text = "E = " + ve[14].ToString() + " v/m";
            textB.text = "B = " + vb[14].ToString() + " v/m";
        }
        else if (pos.z >= 6.369935f && pos.z <= 6.489932f)
        {
            textE.text = "E = " + ve[14].ToString() + " v/m";
            textB.text = "B = " + vb[14].ToString() + " v/m";
        }




        else if (pos.z >= 6.489932f && pos.z <= 6.629928f)
        {
            textE.text = "E = " + ve[15].ToString() + " v/m";
            textB.text = "B = " + vb[15].ToString() + " v/m";
        }
        else if (pos.z >= 6.629928f && pos.z <= 6.749925f)
        {
            textE.text = "E = " + ve[15].ToString() + " v/m";
            textB.text = "B = " + vb[15].ToString() + " v/m";
        }
        else if (pos.z >= 6.749925f && pos.z <= 6.849923f)
        {
            textE.text = "E = " + ve[15].ToString() + " v/m";
            textB.text = "B = " + vb[15].ToString() + " v/m";

        }
        else if (pos.z >= 6.849923f && pos.z <= 6.989919f)
        {
            textE.text = "E = " + ve[16].ToString() + " v/m";
            textB.text = "B = " + vb[16].ToString() + " v/m";
        }
        else if (pos.z >= 6.989919f && pos.z <= 7.089917f)
        {
            textE.text = "E = " + ve[16].ToString() + " v/m";
            textB.text = "B = " + vb[16].ToString() + " v/m";
        }
        else if (pos.z >= 7.089917f && pos.z <= 7.229913f)
        {
            textE.text = "E = " + ve[16].ToString() + " v/m";
            textB.text = "B = " + vb[16].ToString() + " v/m";
        }
        else if (pos.z >= 7.229913f && pos.z <= 7.34991f)
        {
            textE.text = "E = " + ve[17].ToString() + " v/m";
            textB.text = "B = " + vb[17].ToString() + " v/m";
        }
        else if (pos.z >= 7.34991f && pos.z <= 7.469907f)
        {
            textE.text = "E = " + ve[17].ToString() + " v/m";
            textB.text = "B = " + vb[17].ToString() + " v/m";
        }
        else if (pos.z >= 7.469907f && pos.z <= 7.569905f)
        {
            textE.text = "E = " + ve[18].ToString() + " v/m";
            textB.text = "B = " + vb[18].ToString() + " v/m";
        }
        else if (pos.z >= 7.569905f && pos.z <= 7.729901f)
        {
            textE.text = "E = " + ve[18].ToString() + " v/m";
            textB.text = "B = " + vb[18].ToString() + " v/m";
        }




        else if (pos.z >= 7.729901f && pos.z <= 7.849898f)
        {
            textE.text = "E = " + ve[19].ToString() + " v/m";
            textB.text = "B = " + vb[19].ToString() + " v/m";
        }
        else if (pos.z >= 7.849898f && pos.z <= 7.989894f)
        {
            textE.text = "E = " + ve[19].ToString() + " v/m";
            textB.text = "B = " + vb[19].ToString() + " v/m";
        }
        else if (pos.z >= 7.989894f && pos.z <= 8.089896f)
        {
            textE.text = "E = " + ve[19].ToString() + " v/m";
            textB.text = "B = " + vb[19].ToString() + " v/m";
        }
        else if (pos.z >= 8.089896f && pos.z <= 8.229899f)
        {
            textE.text = "E = " + ve[20].ToString() + " v/m";
            textB.text = "B = " + vb[20].ToString() + " v/m";

        }
        else if (pos.z >= 8.229899f && pos.z <= 8.329902f)
        {
            textE.text = "E = " + ve[20].ToString() + " v/m";
            textB.text = "B = " + vb[20].ToString() + " v/m";
        }
        else if (pos.z >= 8.329902f && pos.z <= 8.489905f)
        {
            textE.text = "E = " + ve[21].ToString() + " v/m";
            textB.text = "B = " + vb[21].ToString() + " v/m";
        }


        else
        {
            textE.text = "E = --- ";
            textB.text = "B = --- ";
        }


    }
}
   /* void OnTriggerEnter(Collider other)
    {
        Vector3 posP = other.transform.position;

            if (posP.y == 4.767042f && posP.x == 0.16f)
            {
                textE.text = "E = " + ve[16].ToString() + " v/m";
                textB.text = "B = " + vb[16].ToString() + " v/m";
            }
            if (posP.y == 4.767042f && posP.x != 0.16f)
            {
                textE.text = "E = " + ve[16].ToString() + " v/m";
                textB.text = "B = " + vb[16].ToString() + " v/m";
            }
            if (posP.y == 4.608662f && posP.x == 0.16f)
            {
                textE.text = "E = " + ve[17].ToString() + " v/m";
                textB.text = "B = " + vb[17].ToString() + " v/m";
            }
            if (posP.y == 4.450281f && posP.x == 0.16f)
            {
                textE.text = "E = " + ve[18].ToString() + " v/m";
                textB.text = "B = " + vb[18].ToString() + " v/m";
            }
            if (posP.y == 4.291901f && posP.x == 0.16f)
            {
                textE.text = "E = " + ve[19].ToString() + " v/m";
                textB.text = "B = " + vb[19].ToString() + " v/m";
            }
            if (posP.y == 4.13352f && posP.x == 0.16f)
            {
                textE.text = "E = " + ve[20].ToString() + " v/m";
                textB.text = "B = " + vb[20].ToString() + " v/m";
            }
            if (posP.y == 3.97514f && posP.x == 0.16f)
            {
                textE.text = "E = " + ve[21].ToString() + " v/m";
                textB.text = "B = " + vb[21].ToString() + " v/m";
            }
            if (posP.y == 3.81676f && posP.x == 0.16f)
            {
                textE.text = "E = " + ve[22].ToString() + " v/m";
                textB.text = "B = " + vb[22].ToString() + " v/m";
            }
            if (posP.y == 3.65838f && posP.x == 0.16f)
            {
                textE.text = "E = " + ve[23].ToString() + " v/m";
                textB.text = "B = " + vb[23].ToString() + " v/m";
            }
            if (posP.y == 3.5f && posP.x == 0.16f)
            {
                textE.text = "E = " + ve[24].ToString() + " v/m";
                textB.text = "B = " + vb[24].ToString() + " v/m";
            }
            if (posP.y == 4.921162f && posP.x == 0.16f)
            {
                textE.text = "E = " + ve[1].ToString() + " v/m";
                textB.text = "B = " + vb[1].ToString() + " v/m";
            }
            if (posP.y == 5.075281f && posP.x == 0.16f)
            {
                textE.text = "E = " + ve[2].ToString() + " v/m";
                textB.text = "B = " + vb[2].ToString() + " v/m";
            }
            if (posP.y == 5.229401f && posP.x == 0.16f)
            {
                textE.text = "E = " + ve[3].ToString() + " v/m";
                textB.text = "B = " + vb[3].ToString() + " v/m";
            }
            if (posP.y == 5.38352f && posP.x == 0.16f)
            {
                textE.text = "E = " + ve[4].ToString() + " v/m";
                textB.text = "B = " + vb[4].ToString() + " v/m";
            }
            if (posP.y == 5.53764f && posP.x == 0.16f)
            {
                textE.text = "E = " + ve[5].ToString() + " v/m";
                textB.text = "B = " + vb[5].ToString() + " v/m";
            }
            if (posP.y == 5.69176f && posP.x == 0.16f)
            {
                textE.text = "E = " + ve[6].ToString() + " v/m";
                textB.text = "B = " + vb[6].ToString() + " v/m";
            }
            if (posP.y == 5.84588f && posP.x == 0.16f)
            {
                textE.text = "E = " + ve[7].ToString() + " v/m";
                textB.text = "B = " + vb[7].ToString() + " v/m";
            }
        if (posP.y == 6f && posP.x == 0.16f)
        {
            textE.text = "E = " + ve[8].ToString() + " v/m";
            textB.text = "B = " + vb[8].ToString() + " v/m";
        }
        else
        {
            textE.text = "E = --- v/m";
            textB.text = "B = --- v/m";
        }*/
 

    /* 
 */




