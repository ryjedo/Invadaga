using UnityEngine;
using System.Collections;

public class gibOnCollide: MonoBehaviour
{

	public GameObject gib;
	public int pointValue = 10;

	
	void OnTriggerEnter()
	{
		Instantiate(gib,transform.position,transform.rotation);
		Destroy (gameObject);
		GameObject.FindWithTag("sceneManager").GetComponent<playerMgr>().score += pointValue;
		//GameObject.FindWithTag("sceneManager").GetComponent<playerMgr>().spawnPlayer();
	}

}
