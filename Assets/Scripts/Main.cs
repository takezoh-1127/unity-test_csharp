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
			uint ui = 255;
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
			Debug.Log("  uint:" + ui);
			Debug.Log("  short:" + s);
			Debug.Log("  ushort:" + us);
			Debug.Log("  long:" + l);
			Debug.Log("  ulong:" + ul);
			Debug.Log("  float:" + f);
			Debug.Log("  double:" + d);
			Debug.Log("  char:" + c);
			Debug.Log("  bool:" + b);
			Debug.Log("  string:" + str);

			// 書式指定での出力.
			Debug.Log("### format output.");

			Debug.Log(string.Format("  uint:{0}", ui));
			Debug.Log(string.Format("  uint:0x{0:x}", ui));     // 16進表示.
			Debug.Log(string.Format("  uint:0x{0:X}", ui));     // 16進表示（大文字）.

			Debug.LogFormat("  uint:0x{0:x}", ui);
			Debug.LogFormat("  int:[{0}] uint:[{1}]", i, ui);
			Debug.LogFormat("  uint:[{1}] int:[{0}]", i, ui);

			// ConsoleでASSERTの表示にはなるが実行自体は止まらない.
			Debug.LogAssertion("### assert!!.");

			// Errorも一緒で止まらない.
			Debug.LogError("### error!!.");

			Debug.Log("### check:0");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
