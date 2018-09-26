using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : GameAI {

    //플레이어 스피드
    public int playerSpeed;

    //적 위치 저장
    public Transform enemyTr;

    // Use this for initialization
    void Start () {
        //기본 스피드
        playerSpeed = 10;

        StartCoroutine("Move");
    }

    IEnumerator Move()
    {
        transform.Translate(Vector3.right * playerSpeed);
        yield return new WaitForSeconds(1f);

        StartCoroutine("Move");
    }

    private void Update()
    {
        //적이 범위 안에 있으면 공격
        if (enemyTr == null)
            return;

        float distance = Vector3.Distance(enemyTr.position, transform.position);

        Debug.Log(distance);
        if(distance > 100 && distance < 300)
        {
            Debug.Log("asd");
            Debug.Break();
        }
    }
}