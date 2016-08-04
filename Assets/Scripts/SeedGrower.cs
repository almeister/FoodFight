using UnityEngine;
using System.Collections;

public class SeedGrower : MonoBehaviour {

    GameObject seeds;

    void Awake()
    {
        seeds = (GameObject)transform.FindChild("Seeds").gameObject;
    }

	// Use this for initialization
	void Start () {
        StartCoroutine(growSeeds());
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    IEnumerator growSeeds()
    {
        yield return new WaitForSeconds(3);

        // Replace seeds with Growables

        Destroy(seeds);
    }
}
