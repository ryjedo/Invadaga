using UnityEngine;
using System.Collections;



public class gibExtraPoints: MonoBehaviour
{

	public GameObject[] gibs;
	public float explosionForce = 100;
	public float spawnRadius = 100;
	public int pointValue = 75;

	
	void OnTriggerEnter()
	{
		foreach(GameObject gib in gibs)
		{
			GameObject gibInstance = Instantiate(gib,transform.position + Random.insideUnitSphere*spawnRadius,transform.rotation) as GameObject;
			gibInstance.rigidbody.AddExplosionForce(explosionForce,transform.position,spawnRadius);
		}
		GameObject.FindWithTag("sceneManager").GetComponent<playerMgr>().score += pointValue;
		Destroy (gameObject);
	}

}
