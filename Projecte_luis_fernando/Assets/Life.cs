using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public static int LifeValue = 3;
    Text Lifepoint;

    void Start()
    {
    Lifepoint = GetComponent<Text> ();    
    }

    // Update is called once per frame
    void Update()
    {
      Lifepoint.text="Life: "+LifeValue;  
    }
}
