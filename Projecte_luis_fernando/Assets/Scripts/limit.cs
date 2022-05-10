using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limit : MonoBehaviour
{
    private Transform thetrans;
    public Vector2 Hranger = Vector2.zero;
    public Vector2 Vranger = Vector2.zero;

    void LateUpdate(){
        thetrans.position = new Vector3(
            Mathf.Clamp(transform.position.x, Vranger.x, Vranger.y),
            Mathf.Clamp(transform.position.x, Hranger.x, Hranger.y),
            transform.position.z
        );
    }
    void Start()
    {
        thetrans= GetComponent<Transform>();
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
