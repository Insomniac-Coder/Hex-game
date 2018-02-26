using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//conatains a list of all hex game objects for other scripts to access

public class GameObjectListManager : MonoBehaviour {
    [HideInInspector]
    public GameObject [] list;
    public int length = 121;
    private string naming = "hex";
    private void Start()
    {
        list = new GameObject[length];
        for(int i = 0; i < length; i++)
        {
            list[i] = GameObject.Find(naming + i.ToString());
        }
    }
}
