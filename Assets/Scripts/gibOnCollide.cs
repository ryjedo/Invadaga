using UnityEngine;
using System.Collections;

public class gibOnCollide: MonoBehaviour
{

	public GameObject[] gibs;
	public float explosionForce = 100;
	public float spawnRadius = 100;
	public int pointValue = 10;

	
	void OnTriggerEnter()
	{
		foreach(GameObject gib in gibs)
		{
			GameObject gibInstance = Instantiate(gib,transform.position + Random.insideUnitSphere*spawnRadius,transform.rotation) as GameObject;
			gibInstance.rigidbody.AddExplosionForce(explosionForce,transform.position,spawnRadius);
		}
		//Instantiate(gib,transform.position,transform.rotation);
		Destroy (gameObject);
		GameObject.FindWithTag("sceneManager").GetComponent<playerMgr>().score += pointValue;
		//GameObject.FindWithTag("sceneManager").GetComponent<playerMgr>().spawnPlayer();
	}

}
