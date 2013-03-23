using UnityEngine;
using System.Collections;

public class enemyShoot : MonoBehaviour 
{

	public GameObject bullet;
	public float enemyShootTimer = 2;

	void Start() 
	{
		InvokeRepeating("enemyFire", 2F, enemyShootTimer);
	}
	
	void enemyFire()
	{
		Instantiate(bullet,transform.position,transform.rotation);
	}

}