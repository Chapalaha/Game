using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ExitHouse : MonoBehaviour
{

	//Simple door opening script which looks for 'player' tagged gameobjects. It constantly checks distance between this and player's transform (not raycast based door recognition.)
	//If you set the door to static, the script will automatically remove itself and won't attempt to function.


	public Font font;

	bool doorStatus = false;
	bool playerInRange;

	Transform player;

	void Awake()
	{
		if (this.gameObject.isStatic)
		{
			Destroy(this);
		}
		if (GameObject.FindGameObjectWithTag("Player") != null)
		{
			player = GameObject.FindGameObjectWithTag("Player").transform;
		}
		else
		{
			Debug.Log("Servicedoor.cs couldn't find 'Player' tag in scene. Ignoring class..");
			Destroy(this);
		}
	}

	void Update()
	{
		if (Vector3.Distance(player.position, this.transform.position) < 1.24f)
		{
			playerInRange = true;
			if (Input.GetKeyDown(KeyCode.E))
			{
				SceneManager.LoadScene("Podezd");
			}
		}
		else
		{
			playerInRange = false;
		}
	}

	
	



}
