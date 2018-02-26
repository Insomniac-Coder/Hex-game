using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSpread : MonoBehaviour {
    //this list contains the indicies of all hex game objects which that have to be considered for red team's victory
    List <int> list1 = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
    //access the hex game object manager list
    public GameObjectListManager gameObjectListManager;
	// Use this for initialization
	void Start () {
        //assign the hex game obj list
        gameObjectListManager = this.GetComponent<GameObjectListManager>();
	}
	
	// Update is called once per frame
	void Update () {
        //check if those hex game objects have turned red
		for(int i = 0; i < 11; i++)
        {
            if(gameObjectListManager.list[list1[i]].GetComponent<Renderer>().material.color == Color.red)
            {
                // this helpes in avoiding a condition in which red script gets assigned to a hex game object multiple times
                RedWin rw = gameObjectListManager.list[list1[i]].GetComponent<RedWin>();
                if(rw == null)
                {
                    //if they are red then assign red win script 
                    gameObjectListManager.list[list1[i]].AddComponent(typeof(RedWin));
                }
                else
                {
                    //do nothing
                }
            }
        }
	}
}
