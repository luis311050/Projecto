using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Over : MonoBehaviour
{
    public GameObject GameOverText;
    public static GameObject GAmeOverStatic;

    // Start is called before the first frame update
    void Start()
    {
        Over.GAmeOverStatic = GameOverText;
        Over.GAmeOverStatic.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void show()
    {
        Over.GAmeOverStatic.gameObject.SetActive(true);
    }

}
