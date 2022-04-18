using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    bool forwardmove;
    bool backmove;
    bool rightmove;
    bool leftmove;

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
        if(forwardmove == true){
            transform.position += new Vector3(0, 50 * Time.deltaTime, 0);
        }

        if(backmove == true){
            transform.position += new Vector3(0, -50 * Time.deltaTime, 0);
        }

        if(rightmove == true){
            transform.position += new Vector3(50 * Time.deltaTime, 0, 0);
        }

        if(leftmove == true){
            transform.position += new Vector3(-50 * Time.deltaTime, 0, 0);
        }
    }

    public void forwardButtonDown(){
        forwardmove = true;
    }
    public void forwardButtonUp(){
        forwardmove = false;
    }
    public void backButtonDown(){
        backmove = true;
    }
    public void backButtonUp(){
        backmove = false;
    }
    public void rightButtonDown(){
        rightmove = true;
    }
    public void rightButtonUp(){
        rightmove = false;
    }
    public void leftButtonDown(){
        leftmove = true;
    }
    public void leftButtonUp(){
        leftmove = false;
    }
}