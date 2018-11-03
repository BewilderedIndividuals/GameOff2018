using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamageToTag : MonoBehaviour
{
	[SerializeField]
	private string tag = "Enemy";

	private Rigidbody rb;

	[SerializeField]
	[Range(1f, 10f)]
	float forceMod = 5f;
    // Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody>();
		Destroy(this.gameObject, 5f);
		rb.AddForce(transform.up * forceMod, ForceMode.Impulse);
		print("Sanity");
    }


	private void OnCollisionEnter(Collision collision)
	{
		if (collision.transform.CompareTag(tag))
		{
			print("EnemyHit!");
		}

		Destroy(this.gameObject);
	}

}
