using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Progre : MonoBehaviour {

	
	void Start () {
	
	}
	
	
	void Update () {
        Image img = GetComponent<Image>();
        img.fillAmount = Mathf.Lerp(img.fillAmount,.1f,Time.deltaTime*.7f);
	
	}
}
