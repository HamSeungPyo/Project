using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : GameAI {

    //적 스피드
    public int enemySpeed;

    public Transform playerTr;

	// Use this for initialization
	void Start () {
        enemySpeed = 10;

        StartCoroutine("Move");
    }

    IEnumerator Move()
    {
        transform.Translate(Vector3.left * enemySpeed);
        yield return new WaitForSeconds(1f);

        StartCoroutine("Move");
    }
}
