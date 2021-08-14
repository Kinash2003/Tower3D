using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HpBase : MonoBehaviour
{

	public int HP = 3;
	public Text HPtext;
	
	void Update()
	{
		HPtext.text = HP.ToString();
	}

	void OnTriggerEnter(Collider other)
	{
		if (HP > 0)
		{ 
			if (other.CompareTag("enemyBug"))
			{
			HP -= 1;
			Destroy(other.gameObject);
			Destroy(other.GetComponent<MoveToWayPoints>().hp);


            if(HP ==0)
			{ 
			if (other.tag == "enemyBug")
			{

				SceneManager.LoadScene(0);

			}
			}
				
			}

		}
		
		
	}
}