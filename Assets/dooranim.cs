using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dooranim : MonoBehaviour {

    public GameObject anim;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void launch()
    {
        anim.GetComponent<Animation>().Play("hit");
    }
}
