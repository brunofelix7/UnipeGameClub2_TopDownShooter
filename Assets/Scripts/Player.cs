using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float vel,life;

	// Use this for initialization
	void Start () {
		life = 100;
	}
	
	// Update is called once per frame
	void Update () {
	
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
	
		rb.velocity = new Vector2 (h, v) * vel;
		rb.angularVelocity = 0;

		Vector2 mouse = Input.mousePosition;
		mouse = Camera.main.ScreenToWorldPoint (mouse);
		Vector2 dir = mouse - (Vector2)this.transform.position;

		float angulo = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg;

		this.transform.eulerAngles = new Vector3 (0, 0, angulo);
		if (life <= 0) {
			Destroy (this.gameObject);
		}

		//Debug.Log (life);
	}
}
