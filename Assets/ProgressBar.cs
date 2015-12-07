using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ProgressBar : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update () {
        Image img = GetComponent<Image>();
        img.fillAmount = Mathf.Lerp(img.fillAmount, .1f, Time.deltaTime * .7f);
    }


}
