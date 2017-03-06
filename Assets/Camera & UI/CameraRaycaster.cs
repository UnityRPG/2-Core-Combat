using UnityEngine;
using UnityEngine.EventSystems;
using System.Linq;
using System.Collections.Generic;

public class CameraRaycaster : MonoBehaviour
{
	// INSPECTOR PROPERTIES RENDERED BY CUSTOM EDITOR SCRIPT
	[SerializeField] int[] layerPriorities;

	float maxRaycastDepth = 100f; // Hard coded value
	int topLayerLastFrame = 0;

	// Setup delegates for broadcasting layer changes to other classes
    public delegate void OnCursorLayerChange(int newLayer); // declare new delegate type
    public event OnCursorLayerChange onCursorLayerChange; // instantiate an observer set

    void Update()
	{
		// Check if pointer is over an interactable UI element
		if (EventSystem.current.IsPointerOverGameObject ())
		{
			topLayerLastFrame = 5;
			onCursorLayerChange (5);
			return;
		}

		// Raycast to max depth, every frame as things can move under mouse
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit[] raycastHits = Physics.RaycastAll (ray, maxRaycastDepth);

		// Notify delegates of a change in the layer of the highest priority game object under mouse
		int topLayerThisFrame = HighestPriorityColliderLayerHit (raycastHits);
		if (topLayerThisFrame != topLayerLastFrame)
		{
			topLayerLastFrame = topLayerThisFrame;
			onCursorLayerChange (HighestPriorityColliderLayerHit (raycastHits));
		}

		// Notify delegates of highest priority game object under mouse when clicked

	}

	int HighestPriorityColliderLayerHit (RaycastHit[] raycastHits)
	{
		if (layerPriorities.Length == 0)
		{
			Debug.LogWarning ("No layer priorities set in CameraRaycaster");
		}

		// Form list of layer numbers hit
		List<int> layersHit = new List<int> ();
		foreach (RaycastHit hit in raycastHits)
		{
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