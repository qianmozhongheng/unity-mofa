using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMController : MonoBehaviour {
    //这个类没有用到=-=
    public static BGMController _instance;
    public float Volume=0.6f;
	// Use this for initialization
	void Awake () {
        _instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
