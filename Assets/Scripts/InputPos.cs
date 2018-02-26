using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPos : MonoBehaviour {
    RaycastHit hit;
    GameObject clicked;
    Ray clickray;
    bool p1 = true;
    public GameObject Panel;
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        // Debug.Log(Input.mousePosition);
        //finds out where mouse was clicked
        clickray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetButtonDown("Fire1") && !Panel.activeSelf)
        {
            //draws a ray cast from thaqt point of clicking to the game object
            if (Physics.Raycast(clickray,out hit))
            {//check which game object was hit
                clicked = hit.collider.gameObject;
                //change the color of that game object only if it is not already red or blue or isn't a cube
                if (clicked.layer != 8 && clicked.GetComponent<Renderer>().material.color != Color.red && clicked.GetComponent<Renderer>().material.color != Color.blue)
                {
                    if (p1)
                    {
                        clicked.GetComponent<Renderer>().material.color = Color.red;
                        p1 = false;
                    }
                    else
                    {
                        clicked.GetComponent<Renderer>().material.color = Color.blue;
                        p1 = true;
                    }
                }
            }
        }
    }
}
