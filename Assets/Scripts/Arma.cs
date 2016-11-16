using UnityEngine;
using System.Collections;

public class Arma : MonoBehaviour {
	public Bala prefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Mouse0)){
			Bala bala = (Bala)Instantiate(prefab,this.transform.position,this.transform.rotation);

		}

	}
}
