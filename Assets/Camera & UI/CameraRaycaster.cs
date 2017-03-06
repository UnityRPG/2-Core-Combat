using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class CameraRaycaster : MonoBehaviour
{
	// INSPECTOR PROPERTIES RENDERED BY CUSTOM EDITOR SCRIPT
	[SerializeField] int[] layerPriorities;

	float maxRaycastDepth = 100f; // Hard coded value
	int topLayerLastFrame = 0;

	// Setup delegates for broadcasting layer changes to other classes
    public delegate void OnLayerChange(int newLayer); // declare new delegate type
    public event OnLayerChange onLayerChange; // instantiate an observer set

    void Update()
    {
		// Raycast to max depth, every frame as things can move under mouse
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit[] raycastHits = Physics.RaycastAll (ray, maxRaycastDepth);

		int topLayerThisFrame = HighestPriorityColliderLayerHit (raycastHits);
		if (topLayerThisFrame != topLayerLastFrame)
		{
			onLayerChange (HighestPriorityColliderLayerHit (raycastHits));
			topLayerLastFrame = topLayerThisFrame;
		}
	}

	int HighestPriorityColliderLayerHit (RaycastHit[] raycastHits)
	{
		if (layerPriorities.Length == 0)
		{
			Debug.LogWarning ("No layer priorities set in CameraRaycaster");
		}

		// Form list of layer numbers hit
		List<int> layersHit = new List<int> ();
		foreach (RaycastHit hit in raycastHits) {
			layersHit.Add (hit.collider.gameObject.layer);
		}

		// Broadcast highest priority layer hit
		foreach (int layer in layerPriorities)
		{
			if (layersHit.Contains (layer))
			{
				return layer; // stop looking
			}
		}

		return 0;
	}
}