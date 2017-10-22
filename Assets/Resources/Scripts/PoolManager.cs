using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour {
    [SerializeField] public static List<GameObject> activePool = new List<GameObject>();
    [SerializeField] public static List<GameObject> disabledPool = new List<GameObject>();
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    //Clean up pooled objects marked disabled.	
	}

    public static void AddToPool(GameObject go)
    {
        activePool.Add(go);
    }


}
