using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Progre : MonoBehaviour
{
    float dTime = .8f;

	
	void Start () {
	
	}
	
	
	void Update () {
        Image img = GetComponent<Image>();
        //while(img.fillAmount >= 0)
        img.fillAmount = Mathf.Lerp(img.fillAmount, .1f, Time.deltaTime * dTime);


    }
}
