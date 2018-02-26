using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueWin : MonoBehaviour {
    public GameObjectListManager obj;
    List<GameObject> n = new List<GameObject>(); //neighbours
    // Use this for initialization
    void Start()
    {
        obj = Camera.main.GetComponent<GameObjectListManager>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < obj.list.Length; i++)
        {
            //check if neighbours are blue and prepare a list of blue neighbours
            if (Vector3.Distance(this.transform.position, obj.list[i].transform.position) < 2 && (obj.list[i].GetComponent<Renderer>().material.color == Color.blue) && obj.list[i].name != this.name)
            {
                if (!n.Contains(obj.list[i]))
                {
                    n.Add(obj.list[i]);
                }
            }
        }
        //assign blue win script to neighbouring the blue hex game objects
        for (int i = 0; i < n.Count; i++)
        {
            BlueWin rw = n[i].GetComponent<BlueWin>();
            if (rw == null)
            {
                n[i].AddComponent(typeof(BlueWin));
            }
            else
            {

            }
        }
    }
}
