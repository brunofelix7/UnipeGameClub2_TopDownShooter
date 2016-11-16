using UnityEngine;
using System.Collections;

public class Inimigo : MonoBehaviour {

	public float vel;
	public Player player;
	int life = 100;
	bool tocando;
	public float distseguir;
	// Use this for initialization
	void Start () {
		try{
		player = GameObject.Find ("Player").GetComponent<Player>();
		} catch{
		}

	}
	
	// Update is called once per frame
	void Update () {
		if (player == null) {
			return;
		}
		float distance = Vector2.Distance (this.transform.position, player.transform.position);

		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		if (distance < distseguir) {
			Vector2 dir = (Vector2)player.transform.position - (Vector2)this.transform.position;
			rb.velocity = dir.normalized * vel;
			float angulo = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg;
			this.transform.eulerAngles = new Vector3 (0, 0, angulo);

		} else {
			rb.velocity = Vector2.zero;
			rb.angularVelocity = 0;
		}



		if (tocando)
			player.life -= 10 * Time.deltaTime;
	}

	void OnCollisionEnter2D(Collision2D c){
		tocando = true;
	}
	void OnCollisionExit2D(Collision2D c){
		tocando = false;
	}

	void OnTriggerEnter2D(Collider2D c){
		life -= 25;

		if (life <= 0) {
			Destroy (this.gameObject);
		}
		Debug.Log (life);
	}
}
