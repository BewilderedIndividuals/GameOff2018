using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollowTransform : MonoBehaviour
{
	[SerializeField]
	Transform followTransform;

	Vector3 originalPosition;

	Vector3 speed = Vector3.zero;

	[SerializeField]
	[Range(0f, 1f)]
	float smoothTime = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
		originalPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		transform.position = Vector3.SmoothDamp(transform.position, followTransform.position + originalPosition, ref speed, smoothTime);
    }
}
