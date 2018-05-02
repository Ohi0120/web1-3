using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start() {
        // Hello,Worldをコンソールウィンドウに表示する
        Debug.Log("Hello,World");
        int age;
        age = 30;
        Debug.Log(age);
        float height1 = 160.5f;
        float height2;
        height2 = height1;
        Debug.Log(height2);
        string name;
        name = "kitamura";
        Debug.Log(name);
        int answer;
        answer = 1 + 2;
        Debug.Log(answer);
        int n1 = 8;
        int n2 = 9;
        answer = n1 + n2;
        Debug.Log(answer);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
