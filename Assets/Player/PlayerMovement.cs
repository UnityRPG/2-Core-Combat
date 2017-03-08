using System;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

[RequireComponent(typeof (ThirdPersonCharacter))]
public class PlayerMovement : MonoBehaviour
{
	public static bool isInDirectMode = false;

    [SerializeField] float walkMoveStopRadius = 0.2f;
    [SerializeField] int walkableLayer = 8;

    ThirdPersonCharacter thirdPersonCharacter;   // A reference to the ThirdPersonCharacter on the object
    CameraRaycaster cameraRaycaster;
    Vector3 currentDestination, clickPoint;


    private void Start()
    {
        cameraRaycaster = Camera.main.GetComponent<CameraRaycaster>();
		cameraRaycaster.notifyMouseClickObservers += OnMouseClicked; // registering
        thirdPersonCharacter = GetComponent<ThirdPersonCharacter>();
		currentDestination = transform.position;
		clickPoint = transform.position;
    }

    // Fixed update is called in sync with physics
    private void FixedUpdate()
    {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		if (h > 0 || v > 0)
		{
			isInDirectMode = true;
		}

		if (isInDirectMode)
		{
			Cursor.visible = false;
			ProcessDirectMovement (h, v);
		}
		else
		{
			Cursor.visible = true;
			WalkToLastClickPoint ();
		}
	}

	void ProcessDirectMovement(float horizontal, float vertical)
    {
		if (RangedWeapon.isFiring)
		{
			thirdPersonCharacter.Move (Vector3.zero, false, false);
		}
		else
		{
			// calculate camera relative direction to move:
			Vector3 cameraForward = Vector3.Scale (Camera.main.transform.forward, new Vector3 (1, 0, 1)).normalized;
			Vector3 movement = vertical * cameraForward + horizontal * Camera.main.transform.right;
			thirdPersonCharacter.Move (movement, false, false);
			currentDestination = transform.position;
		}
    }

	void OnMouseClicked(RaycastHit hit, int layerHit)
    {
		isInDirectMode = false;

		if (layerHit == walkableLayer)
		{
			clickPoint = hit.point;
            currentDestination = clickPoint;
		}
    }

    void WalkToLastClickPoint()
    {
        var playerToClickPoint = currentDestination - transform.position;
        if (playerToClickPoint.magnitude >= walkMoveStopRadius)
        {
            thirdPersonCharacter.Move(playerToClickPoint, false, false);
        }
        else
        {
            thirdPersonCharacter.Move(Vector3.zero, false, false);
        }
    }
}

