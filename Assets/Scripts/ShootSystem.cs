
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class ShootSystem : MonoBehaviour {
 public float damage = 1;
public float timeout = 0.2f;
public string[] targetTags = {"Target_1", "Target_2"};
private float curTimeout;
void Update() 
{
	RaycastHit hit;
	Ray ray = Camera.main.ScreenPointToRay(transform.position);
	if (Physics.Raycast(ray, out hit))
	{
		if(Input.GetMouseButton(0))
		{
			foreach(string currentTag in targetTags)
			{
				if(currentTag == hit.transform.tag)
				{
					curTimeout += Time.deltaTime;
					if(curTimeout > timeout)
					{
						curTimeout = 0;
						hit.transform.GetComponent<EnemyHealth>().AddDamage(damage);
					}
				}
			}
		}
		else
		{
			curTimeout = timeout + 1;
		}
	}
}
}