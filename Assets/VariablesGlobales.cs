using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VariablesGlobales : MonoBehaviour {
     
    public static VariablesGlobales vg;
    public Text t;

  
    // Use this for initialization
    private void Awake()
    {
        PlayerPrefs.SetString("txt", t.text);
        t.text = PlayerPrefs.GetString("txt");
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {
		
	}
}
