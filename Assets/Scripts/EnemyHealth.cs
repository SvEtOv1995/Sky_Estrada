using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{

	public float HP = 10;

	public Scrollbar bar;

	public void AddDamage(float damage)
	{
		HP -= damage;

		bar.size = HP;

		if(HP <= 0)
		{
			Destroy(gameObject);
		}
	}
}