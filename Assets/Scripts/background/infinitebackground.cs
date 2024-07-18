using UnityEngine;
using System.Collections;

public class infinitebackground : MonoBehaviour {


	public float backgroundsize;
	private Transform cameratransform;
	private Transform[] layers;
	private float viewzone = 20;
	private int leftindex;
	private int rightindex;

	private void Start()
	{
		cameratransform = Camera.main.transform;
		layers = new Transform[transform.childCount];
		for (int i = 0; i < transform.childCount; i++)
			layers [i] = transform.GetChild (i);
		leftindex = 0;
		rightindex = layers.Length - 1;
	}

	private void Update ()
	{
		if (cameratransform.position.x > (layers [rightindex].transform.position.x - viewzone))
			Scrollright ();
	}

	private void ScrollLeft()
	{
		int lastRight = rightindex;
		layers [rightindex].position = Vector3.right * (layers [leftindex].position.x - backgroundsize);
		leftindex = rightindex;
		rightindex--;
		if (rightindex < 0)
			rightindex = layers.Length - 1;
	}

	private void Scrollright()
	{
		int lastleft = rightindex;
		layers [leftindex].position = Vector3.right * (layers [rightindex].position.x + backgroundsize);
		rightindex = leftindex;
		leftindex++;
		if (leftindex == layers.Length)
			leftindex = 0;
	}




}
