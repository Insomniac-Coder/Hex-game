using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WhoWon : MonoBehaviour {
    List<int> list1 = new List<int>(new int[] { 10, 21, 32, 43, 54, 65, 76, 87, 98, 109, 120});
    List<int> list2 = new List<int>(new int[] { 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120 });
    GameObjectListManager obj;
    RedWin rw;
    BlueWin bw;
    public GameObject ReloadScript;
    public GameObject Panel;
    public Text Winningmessage;
    // Use this for initialization
    void Start () {
        obj = this.GetComponent<GameObjectListManager>();
    }
    // Update is called once per frame
    void Update () {
		for(int i = 0; i < 11; i++)
        {
            rw = obj.list[list2[i]].GetComponent<RedWin>();
            if(rw == null)
            {
                //do nothing
            }
            else
            {
                Panel.SetActive(true);
                Winningmessage.text = "Red Won!";
                rw = null;
            }
            bw = obj.list[list1[i]].GetComponent<BlueWin>();
            if (bw == null)
            {
                //do nothing
            }
            else
            {
                Panel.SetActive(true);
                Winningmessage.text = "Blue Won!";
                bw = null;
            }
        }
	}
    public void Refresh()
    {
        ReloadScript.GetComponent<Refresh>().enabled = true;
    }
}
