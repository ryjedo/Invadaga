using UnityEngine;
using System.Collections;

public class spawnObject : MonoBehaviour
{

	public GameObject enemy;
	public GameObject powerUp;
	public float spawnEnemyTimer = 1f;
	public float spawnPowerUpTimer = 10f;
	private float spawnEnemyLocation;
	private float spawnPowerUpLocation;

	void spawnEnemy()
	{
		Instantiate(enemy, new Vector3 (spawnEnemyLocation,0,80), Quaternion.identity);
		spawnEnemyLocation = Random.Range (-160, 160);
	}

	void spawnPowerUp()
	{
		Instantiate(powerUp, new Vector3 (spawnPowerUpLocation,0,80), Quaternion.identity);
		spawnPowerUpLocation = Random.Range (-160, 160);
	}

	void Start()
	{
		InvokeRepeating("spawnEnemy", .2F, spawnEnemyTimer);
		InvokeRepeating("spawnPowerUp", 10F, spawnPowerUpTimer);
	}

}
