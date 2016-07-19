using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Logo : MonoBehaviour {
    float time = 0.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if (time >= 3.0f)
        {
            SceneManager.LoadScene(1);
        }
	}
}
