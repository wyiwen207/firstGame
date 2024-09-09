using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("start");
    }

    // Update is called once per frame
    void Update()
    {
        //print("Update");
        if(Input.GetKey(KeyCode.RightArrow)){
            this.gameObject.transform.position += new Vector3(0.1f,0,0);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            this.gameObject.transform.position -= new Vector3(0.1f,0);
        }
    }
}
