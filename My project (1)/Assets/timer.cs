using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class timer : MonoBehaviour
{
public Text UItext;
private float time = 0;

private void start()
{
 
}

void Update()
{
    time += Time.deltaTime;
    UItext.text = "Time: "+time.ToString("f0");
}

}
