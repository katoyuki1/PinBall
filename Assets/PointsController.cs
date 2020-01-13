using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsController : MonoBehaviour {

	//合計点
	private static int points = 0;

	//合計点を表示するテキスト
	private GameObject pointsText;

	// Use this for initialization
	void Start () {
		//シーン中のPoinstsTextオブジェクトを取得
		this.pointsText = GameObject.Find("PointsText");
	}
	
	// Update is called once per frame
	void Update () {
		//現在の得点を設定
		pointsText.GetComponent<Text> ().text = points.ToString();
	}

	//衝突時に呼ばれる関数
	void OnCollisionEnter(Collision other) {

		// タグによって加算する得点を変える
		if (tag == "SmallStarTag") {
			points += 10;
		} else if (tag == "LargeStarTag") {
			points += 20;
		} else if (tag == "SmallCloudTag") {
			points += 5;
		} else if (tag == "LargeCloudTag") {
			points += 15;
		}

		//衝突したオブジェクトのタグをConsoleに出力
		Debug.Log(tag);
	}
}
