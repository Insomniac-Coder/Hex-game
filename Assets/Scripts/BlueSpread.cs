using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSpread : MonoBehaviour {
    List<int> list2 = new List<int>(new int[] { 0, 11, 22, 33, 44, 55, 66, 77, 88, 99, 110 });
    public GameObjectListManager gameObjectListManager;
    // Use this for initialization
    void Start () {
        gameObjectListManager = this.GetComponent<GameObjectListManager>();
    }
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < 11; i++)
        {
            if (gameObjectListManager.list[list2[i]].GetComponent<Renderer>().material.color == Color.blue)
            {
                BlueWin rw = gameObjectListManager.list[list2[i]].GetComponent<BlueWin>();
                if (rw == null)
                {
                    gameObjectListManager.list[list2[i]].AddComponent(typeof(BlueWin));
                }
                else
                {

                }
            }
        }
    }
}
