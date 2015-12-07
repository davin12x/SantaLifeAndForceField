using UnityEngine;
using System.Collections;

public class CirlceColl : MonoBehaviour {
    private CircleCollider2D myCollider;
    public Transform particles;
    private float time = 2;

    // Use this for initialization
    void Start () {
        myCollider = transform.GetComponent<CircleCollider2D>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (myCollider.radius >3)
        {
            Instantiate(particles, transform.position, transform.rotation);
            myCollider.radius += 2f;

        }
        else
        {
            myCollider.enabled = false;
        }


    }
}
