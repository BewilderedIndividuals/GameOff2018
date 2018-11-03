using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMovement : MonoBehaviour
{
	float hori = 0f;
	float verti = 0f;

	Vector3 euler;

    // Start is called before the first frame update
    void Start()
    {
		euler = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {


		hori = Input.GetAxis("Horizontal");
		verti = Input.GetAxis("Vertical");
		if(hori == 0f && verti == 0f)
		{
			return;
		}
		euler += new Vector3(-verti, hori, 0f);
		transform.rotation = Quaternion.Euler(euler);
		
		//transform.eulerAngles = euler;
	}
}
