using UnityEngine;
using System.Collections;



public class gibAddShield: MonoBehaviour
{

	public GameObject[] gibs;
	public float explosionForce = 7500;
	public float spawnRadius = 10;
	public int pointValue = 15;

	
	void OnTriggerEnter()
	{
		foreach(GameObject gib in gibs)
		{
			GameObject gibInstance = Instantiate(gib,transform.position + Random.insideUnitSphere*spawnRadius,transform.rotation) as GameObject;
			gibInstance.rigidbody.AddExplosionForce(explosionForce,transform.position,spawnRadius);
		}
		GameObject.FindWithTag("sceneManager").GetComponent<playerMgr>().score += pointValue;
		GameObject.FindWithTag("Shield").GetComponent<respawnShield>().shieldFuel += 10;
		Destroy (gameObject);
	}

}
