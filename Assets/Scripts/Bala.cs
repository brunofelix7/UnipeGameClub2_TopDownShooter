using UnityEngine;
using System.Collections;

public class Bala : MonoBehaviour {
	public float vel;

	// Use this for initialization
	void Start () {
		
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();

		rb.velocity = this.transform.right * vel;
	}
	
	// Update is called once per frame
	void Update () {


	}

	void OnTriggerEnter2D(Collider2D c){
		Destroy (this.gameObject);
	}
		
}
