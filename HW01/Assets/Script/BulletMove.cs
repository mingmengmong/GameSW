using System;
using System.Collections.Generic;
using UnityEngine;

namespace Script {
	public class BulletMove : MonoBehaviour {
//		public GameObject player;
		public float bulletSpeed = 5.0f;
		public Vector3 bulletDirection = Vector3.forward;
		public LifeUI lifeUi;

		public void OnEnable() {
			
		}

		public void Update() {
			this.transform.position += bulletSpeed * Time.deltaTime * bulletDirection;
		}

		public void OnCollisionEnter(Collision other) {
//			Debug.Log("collision");
//			Debug.Log(other.gameObject.name);

			string objName = other.gameObject.name;

			if (objName == "Player") {
				lifeUi.lifeDown();
			}
			
			if (objName == "Player" || objName.StartsWith("Edge")) {
				Destroy(this.gameObject);
			}

//			Debug.Log("destroy bullet");
		}
	}
}