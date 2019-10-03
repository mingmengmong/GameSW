using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Script {
	public class BulletCreate : MonoBehaviour {
		private float delayTime = 1.0f;
		public float intervalTime = 1.0f;
		
		private float objPosition = 4.5f;
		private float positionY = 0.5f;

		public GameObject bullet;
		public GameObject player;

		public void OnEnable() {
			InvokeRepeating("createBullet", delayTime, intervalTime);
		}

		public void OnDisable() {
			CancelInvoke("createBullet");
		}

		private void createBullet() {
			bool xzPosition = Random.Range(0f, 1f) >= 0.5f;
			float edgePosition = Random.Range(0f, 1f) >= 0.5f ? -1f : 1f;
			float randomPosition = Random.Range(-1 * objPosition, objPosition);

			Vector3 bulletPosition;
			if (xzPosition) {
				bulletPosition = new Vector3(randomPosition, positionY, edgePosition*objPosition);
			} else {
				bulletPosition = new Vector3(edgePosition*objPosition, positionY, randomPosition);
			}

			Vector3 bulletDirection = player.transform.position - bulletPosition;

			GameObject newBullet = Instantiate(bullet);
			newBullet.transform.position = bulletPosition;
			newBullet.GetComponent<BulletMove>().bulletDirection = bulletDirection.normalized;
			newBullet.SetActive(true);
		}
	}
}