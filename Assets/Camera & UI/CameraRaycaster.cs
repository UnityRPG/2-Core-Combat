using UnityEngine;
using UnityEngine.EventSystems;
using System.Linq;
using System.Collections.Generic;

public class CameraRaycaster : MonoBehaviour
{
	// INSPECTOR PROPERTIES RENDERED BY CUSTOM EDITOR SCRIPT
	[SerializeField] int[] layerPriorities;

	float maxRaycastDepth = 100f; // Hard coded value
	int topPriorityLayerLastFrame = 0;
	GameObject fallBackGameObject = null;

	// Setup delegates for broadcasting layer changes to other classes
    public delegate void OnCursorLayerChange(int newLayer); // declare new delegate type
    public event OnCursorLayerChange notifyLayerChangeObservers; // instantiate an observer set

	void Start()
	{
		fallBackGameObject = new GameObject ("Fallback Game Object");
	}

    void Update()
	{
		// Check if pointer is over an interactable UI element
		if (EventSystem.current.IsPointerOverGameObject ())
		{
			topPriorityLayerLastFrame = 5;
			notifyLayerChangeObservers (5);
			return; // Stop looking for other objects
		}

		// Raycast to max depth, every frame as things can move under mouse
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit[] raycastHits = Physics.RaycastAll (ray, maxRaycastDepth);

		// Notify delegates of a change in the layer of the highest priority game object under mouse
		int topPriorityLayerThisFrame = HighestPriorityColliderLayerHit (raycastHits);
		if (topPriorityLayerThisFrame != topPriorityLayerLastFrame)
		{
			topPriorityLayerLastFrame = topPriorityLayerThisFrame;
			notifyLayerChangeObservers (HighestPriorityColliderLayerHit (raycastHits));
		}
			
		// Notify delegates of highest priority game object under mouse when clicked
		print (HighestPriorityGameobjectHit(raycastHits).name);
	}

	GameObject HighestPriorityGameobjectHit (RaycastHit[] raycastHits)
	{
		// Form list of layer numbers hit
		List<int> layersOfHitColliders = new List<int> ();
		foreach (RaycastHit hit in raycastHits)
		{
			layersOfHitColliders.Add (hit.collider.gameObject.layer);
		}

		// Step through layers in order of priority looking for a gameobject with that layer
		foreach (int layer in layerPriorities)
		{
			foreach (RaycastHit hit in raycastHits)
			{
				if (hit.collider.gameObject.layer == layer)
				{
					return hit.collider.gameObject; // stop looking
				}
			}
		}
		return fallBackGameObject; // because cannot use GameObject? nullable
	}

	int HighestPriorityColliderLayerHit (RaycastHit[] raycastHits)
	{
		if (layerPriorities.Length == 0)
		{
			Debug.LogWarning ("No layer priorities set in CameraRaycaster");
		}

		// Form list of layer numbers hit
		List<int> layersOfHitColliders = new List<int> ();
		foreach (RaycastHit hit in raycastHits)
		{
			layersOfHitColliders.Add (hit.collider.gameObject.layer);
		}

		// Broadcast highest priority layer hit
		foreach (int layer in layerPriorities)
		{
			if (layersOfHitColliders.Contains (layer))
			{
				return layer; // stop looking
			}
		}

		return 0;
	}
}