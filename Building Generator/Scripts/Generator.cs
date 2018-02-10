using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

    public GameObject[] seed;
    public float scale = 1;


	// Use this for initialization
	void Start () {
        Generate();
	}
	
	// Update is called once per frame
	void Generate () {
        GameObject Building = Instantiate(seed[Random.Range(0, seed.Length)], transform.position, transform.rotation);
        Building.transform.localScale = new Vector3(scale, scale, scale);
	}
}
