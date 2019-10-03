using System;
using UnityEngine;

namespace Script {
	public class LifeUI : MonoBehaviour {
		public int lifeCount = 3;

		public void OnEnable() {
			lifeCount = 3;
			for (int i = 0; i < lifeCount; ++i) {
				this.transform.GetChild(i).gameObject.SetActive(true);
			}
		}

		public void Update() {
			if (lifeCount == 0) {
				Time.timeScale = 0;
			} else {
				Time.timeScale = 1;
			}
		}

		public void lifeDown() {
			--lifeCount;
			this.transform.GetChild(lifeCount).gameObject.SetActive(false);
		}
	}
}