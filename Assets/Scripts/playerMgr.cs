using UnityEngine;
using System.Collections;

public class playerMgr : MonoBehaviour 
{

	public GameObject player;
	public float spawnLocZ = -80;
	public int lives = 2;
	public int score;
		
	
	
	
	public void spawnPlayer()
	{
		if(lives > 0)
			Instantiate(player, new Vector3 (0,0,spawnLocZ), Quaternion.identity);
		Application.Quit();
		//spawn gameover ui
	}

	void Start () 
	{
		Invoke("spawnPlayer", 0);
		//Instantiate(player, new Vector3 (0,0,spawnLocZ), Quaternion.identity);
		//Instantiate(player, new Vector3 (0,0,spawnLocZ), transform.rotation);
	}
	void update ()
	{
		Debug.Log(score);
	}
}
