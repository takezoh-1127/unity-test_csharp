using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // そもそも使える型は？
        {
            Debug.Log("### 基本データ型");

            byte by = 0;
            sbyte sby = 0;
            int i = 0;
            uint ui = 0;
            short s = 0;
            ushort us = 0;
            long l = 0;
            ulong ul = 0;
            float f = 0.0f;
            double d = 0.0;
            char c = 'a';
            bool b = true;
            //object
            string str = "aaa";

            Debug.Log("  byte:" + by);
            Debug.Log("  sbyte:" + sby);
            Debug.Log("  int:" + i);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
