using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

	public float damage = 1;
	public string[] targetTags = {"Target_1", "Target_2"};

	void OnTriggerEnter(Collider coll)
	{
		foreach(string currentTag in targetTags)
		{
			if(currentTag == coll.transform.tag)
			{
				coll.transform.GetComponent<EnemyHealth>().AddDamage(damage);
			}
		}
		Destroy(gameObject);
	}
}