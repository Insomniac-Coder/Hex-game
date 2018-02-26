using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedWin : MonoBehaviour {
    public GameObjectListManager obj;
    List<GameObject> n = new List<GameObject>(); //neighbours
    // Use this for initialization
    void Start () {
		obj = Camera.main.GetComponent<GameObjectListManager>();
    }
	
	// Update is called once per frame
	void Update () {
        //check if neighbours are red and assign the red win script to them too
        for (int i = 0; i < obj.list.Length; i++)
        { //checks if neighbours are red and creates a list of those neighbours
            if (Vector3.Distance(this.transform.position, obj.list[i].transform.position) < 2 && (obj.list[i].GetComponent<Renderer>().material.color == Color.red) && obj.list[i].name != this.name)
            {
                if (!n.Contains(obj.list[i]))
                {
                    n.Add(obj.list[i]);
                }
            }
        }
        //assigns red win script to them
        for(int i = 0; i < n.Count; i++)
        {
            //avoid multiple time attachement of the same script on any hex game object
            RedWin rw = n[i].GetComponent<RedWin>();
            if(rw == null)
            {
                n[i].AddComponent(typeof(RedWin));
            }
            else
            {

            }
        }
    }
}
