#define _ENABLE_HOGE

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//#define _ENABLE_HOGE		// ファイルの先頭で宣言しないとエラーになる.

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

#if _ENABLE_HOGE
			Debug.Log("### #if _ENABLE_HOGE");
#endif

//#if defined(_ENABLE_HOGE)
			//Debug.Log("### #if defined(_ENABLE_HOGE)");
//#endif
		}

		// 配列.
		{
			// ↓NG
			// C,C++の様な書き方はダメ.
			//int array[10];

			int[] array = new int[10];

			array[0] = 1;

			Debug.Log("### Array.");

			for(int i = 0; i < array.Length; i++)
			{
				Debug.LogFormat("  [{0}]:{1}", i, array[i]);
			}
		}

		{
			int[] array = new int[10]{1,2,3,4,5,6,7,8,9,10};

			// foreachの書き方.
			foreach(int v in array)
			{
				Debug.LogFormat("  {0}", v);
			}
		}

		{
			int[] array = new int[] { 10, 20, 30, 40, 50 };

			// auto変数みたいにvarだと型を明示的に指定する必要が無い？.
			foreach(var v in array)
			{
				Debug.LogFormat("  {0}", v);
			}
		}

		{
			float[] array = new float[] { 1.5f, 2.5f, 3.5f, 4.5f, 5.5f };

			foreach(var v in array)
			{
				Debug.LogFormat("  {0}", v);
			}
		}

		// 可変長配列.
		{
			Debug.Log("### List<int>");

			List<int> list = new List<int>();

			// 追加.
			list.Add(10);
			list.Add(20);
			list.Add(30);
			list.Add(40);

			Debug.LogFormat("  count:[{0}]", list.Count);

			// 配列の様にアクセスできるみたい.
			for(int i = 0; i < list.Count; i++)
			{
				Debug.LogFormat("  [{0}]:[{1}]", i, list[i]);
			}

			// 挿入.
			list.Insert(2, 100);

			Debug.LogFormat("  count:[{0}]", list.Count);

			foreach(var v in list)
			{
				Debug.LogFormat("  [{0}]", v);
			}

			// ソート.
			Debug.Log("### sort.");

			list.Sort();

			foreach(var v in list)
			{
				Debug.LogFormat("  [{0}]", v);
			}

			// 降順にソート.
			// ラムダ式.
			list.Sort((a, b) => b - a);

			foreach (var v in list)
			{
				Debug.LogFormat("  [{0}]", v);
			}
		}

		{
			Debug.Log("### List<float>");

			List<float> list = new List<float>();

			list.Add(2.5f);
			list.Add(2.6f);
			list.Add(2.7f);
			list.Add(4.5f);
			list.Add(6.5f);
			list.Add(8.5f);

			list.Insert(2, 10.5f);

			foreach (var v in list)
			{
				Debug.LogFormat("  [{0}]", v);
			}

			list.Sort();
			list.Reverse();

			Debug.Log("##");

			//list.Sort((a, b) => { return a < b ? 1 : (b > a ? -1 : 0); });
			//list.Sort((a, b) => (int)(b - a));

			foreach (var v in list)
			{
				Debug.LogFormat("  [{0}]", v);
			}
		}

		// 連想配列.
		{
			Debug.Log("### Dictionary<int, string>");

			Dictionary<int, string> dic = new Dictionary<int, string>();

			dic.Add(1, "Hoge1");
			dic.Add(2, "Hoge2");

			dic[3] = "Hoge3";

			Debug.LogFormat("  val:[{0}]", dic[1]);

			// キーの列挙.
			foreach(var key in dic.Keys)
			{
				Debug.LogFormat("  key:[{0}]", key);
			}

			// 要素の列挙.
			foreach(var val in dic.Values)
			{
				Debug.LogFormat("  val:[{0}]", val);
			}

			// キーと要素の列挙.
			foreach(KeyValuePair<int,string> pair in dic)
			{
				Debug.LogFormat("  [{0}] : [{1}]", pair.Key, pair.Value);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
