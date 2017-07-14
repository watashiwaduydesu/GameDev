using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {

	[SerializeField]      //dùng để có thể thay đổi trong cửa sổ Inspector
	private GameObject bullet; // sẽ được kéo viện đạn vào trong cửa sổ Inspector
	private bool canShoot = true; // ràng buộc cho phép bắn
	// Use this for initialization
	void Awake()
	{
		
	}
	void Start () {
		
	}
	
	// Bắn viên đạn mỗi 0.2 giây
	void Update () 
	{
		if (canShoot) {
			StartCoroutine (shoot ());
		}
	}
	IEnumerator shoot()
	{
		canShoot = false;
		Vector3 temp = gameObject.transform.position;
		temp.y += 0.7f;
		Instantiate (bullet, temp, Quaternion.identity);
		yield return new WaitForSeconds (0.2f);
		canShoot = true;
	}
}
