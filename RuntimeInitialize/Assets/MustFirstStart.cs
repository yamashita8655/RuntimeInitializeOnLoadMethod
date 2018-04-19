using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MustFirstStart : MonoBehaviour {

	//// これだと、AwakeとStartの後になってしまう
	//[RuntimeInitializeOnLoadMethod()]
	//static void EntryPoint() {
	//	//new GameObject ("sample");
	//	Debug.Log("MustFirstStart EntryPoint");
	//}

	// これで、AwakeとStartの前になる
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	static void EntryPoint() {
		//new GameObject ("sample");
		Debug.Log("MustFirstStart EntryPoint");
		GameObject obj = new GameObject("EntryPoint");
		EntryPoint c = obj.AddComponent<EntryPoint>();
		c.Initialize();
	}

	// Use this for initialization
	void Awake () {
		Debug.Log("MustFirstStart Awake");
	}

	// Use this for initialization
	void Start () {
		Debug.Log("MustFirstStart Start");
	}
}
