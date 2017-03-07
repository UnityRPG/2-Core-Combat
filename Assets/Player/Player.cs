using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField] float maxHealthPoints = 100f;
	[SerializeField] GameObject cameraPrefab = null;

    float currentHealthPoints = 100f;


	void Awake() // All cascades from the player
	{
		if (GameObject.FindObjectsOfType<Player> ().Length > 1)
		{
			Debug.LogError ("More than one player in the scene!");
		}

		if (GameObject.FindObjectsOfType<Camera> ().Length >= 1)
		{
			Debug.LogError ("Stop game and delete any cameras from scene");
		}
		else
		{
			Instantiate (cameraPrefab);	
		}
	}

    public float healthAsPercentage {
		get {
			return currentHealthPoints / maxHealthPoints;
		}
	}
		
	public Vector3 GetForwardDirection()
	{
		return transform.forward;
	}
		
}

