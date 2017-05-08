using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAttribute : MonoBehaviour {

	public int test_int = 10;		// 初期値も反映される.
	public float test_float = 20.0f;
	public string test_string = "test";
	public GameObject test_gameobject;
	public ElementAttr test_enum;

	[Range(0.0f, 10.0f)]
	public float test_float_range = 5.0f;
	public float test_float2;

	[Header("----")]

	// ↓privateもinspectorに表示することができる.
	[SerializeField]
	private int test_int_private;

	[Multiline(2)]
	public string test_multiline;

	[TextArea(2, 5)]
	public string test_textarea;

	private int _test_int;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
