using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour
{
	public GameObject platform;
	public float moveSpeed;
	public Transform currentPoint;
	public Transform[] points;
	public int pointSelection;

	// Use this for initialization
	void Start ()
	{
		this.currentPoint = this.points [this.pointSelection];
	}
	
	// Update is called once per frame
	void Update ()
	{
		this.platform.transform.position = Vector3.MoveTowards (this.platform.transform.position, this.currentPoint.position, Time.deltaTime * this.moveSpeed);

		if (this.platform.transform.position == this.currentPoint.position)
        {
            pointSelection++;
            if(pointSelection == points.Length)
            {
                pointSelection = 0;
            }
            currentPoint = points[pointSelection];
		
		}
	}
}
