using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Refresh : MonoBehaviour {
    IEnumerator Start()
    {
        AsyncOperation async;
        async = SceneManager.LoadSceneAsync(0);
        yield return async;
    }
}
