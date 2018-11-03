using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
	[SerializeField]
	GameObject bullet;

	[SerializeField]
	string buttonString = "Fire1";

	Rigidbody graphicBody;
    // Start is called before the first frame update
    void Start()
    {
		graphicBody = GetComponentInChildren<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetButtonDown(buttonString))
		{
			GameObject.Instantiate(bullet, transform.position + transform.up *2f + Vector3.up /2f, transform.rotation, null);
			graphicBody.AddForce(0f, 0f, -1f, ForceMode.Impulse);
		}
    }
}
