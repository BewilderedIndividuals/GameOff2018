using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	Renderer rend;
	Rigidbody rb;

	[SerializeField]
	string buttonString = "Fire1";

	[SerializeField]
	[Range(1f, 10f)]
	float SpeedMod = 2f;

	float hori = 0f;
	float verti = 0f;

	[SerializeField]
	public Item heldItem;

    // Start is called before the first frame update
    void Start()
    {
		rend = GetComponent<Renderer>();
		rb = GetComponent<Rigidbody>();

	}

    // Update is called once per frame
    void Update()
	{
		ItemInteraction();
		Movement();
	}

	private void ItemInteraction()
	{
		if (Input.GetButtonDown(buttonString))
		{

			if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, 1f))
            {
                if (hit.transform.GetComponent<IInteractable>() != null)
                {
                    print(hit.transform.name);
                    heldItem = hit.transform.GetComponent<IInteractable>().Interact(heldItem);
                }
            }


		}
	}

	//Anything related to the rigidbody of the player here.
	private void Movement()
	{
		hori = Input.GetAxis("Horizontal");
		verti = Input.GetAxis("Vertical");

		if (hori == 0f && verti == 0f)
		{
			return; //No input, bye.
		}

		rb.velocity = new Vector3(hori, 0f , verti) * SpeedMod;

	}
}
