using UnityEngine;
using System.Collections;

public class spawnObject : MonoBehaviour
{

	public GameObject enemy;
	public GameObject[] powerUps;
	public float spawnEnemyTimer = 1f;
	public float spawnPowerUpTimer = 10f;
	private float spawnEnemyLocation;
	private float spawnPowerUpLocation;
	private int pickPowerUp;
	
	void spawnEnemy()
	{
		Instantiate(enemy, new Vector3 (spawnEnemyLocation,0,95), Quaternion.identity);
		spawnEnemyLocation = Random.Range (-160, 160);
	}

	void spawnPowerUp()
	{
		pickPowerUp = Random.Range(0,3);
		Instantiate(powerUps[pickPowerUp], new Vector3 (spawnPowerUpLocation,0,95), Quaternion.identity);
		spawnPowerUpLocation = Random.Range (-160, 160);
	}

	void Start()
	{
		InvokeRepeating("spawnEnemy", .2F, spawnEnemyTimer);
		InvokeRepeating("spawnPowerUp", 10F, spawnPowerUpTimer);
	}

}
