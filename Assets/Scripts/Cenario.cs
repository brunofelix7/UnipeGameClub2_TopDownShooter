using UnityEngine;
using System.Collections;

	

public class Cenario : MonoBehaviour {
	public float xMin, xMax, yMin, yMax;
	public Inimigo prefab;



	// Use this for initialization
	void Start () {
		InvokeRepeating ("CriaEnemy", 4, 4);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void CriaEnemy(){
		float x = Random.Range (xMin, xMax);
		float y = Random.Range (yMin, yMax);
		Instantiate(prefab,new Vector3(x,y,0),Quaternion.identity);
	}
}
