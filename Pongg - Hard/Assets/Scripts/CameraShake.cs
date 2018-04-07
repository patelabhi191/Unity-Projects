using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

	Vector3 originalPos;
	float shakeDuration = 0.0f;
	float shakeAmount = 1.0f;
	float decreaseFactor = 1.0f;
	public Camera c;
	public GameObject Ball;

	void Start()
	{
		originalPos = c.transform.position;

		//originalPos = c.transform.localScale;
	}

	void Update()
	{
		if (shakeDuration > 0)
		{
			c.transform.position = originalPos + Random.insideUnitSphere * shakeAmount;
			c.orthographicSize = 4.8f;
			shakeDuration -= Time.deltaTime * decreaseFactor;
		}
		else
		{
			shakeDuration = 0.0f;
			c.transform.position = originalPos;
			c.orthographicSize = 5;
		}
		if (Ball.transform.position.x>9.5f || Ball.transform.position.x<-9.5f)
		{
			shakeDuration = 0.5f;
		}
	}
	public void setDuration(float duration)
	{
		shakeDuration = duration;
	}
}
