using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject square; //프리팹을 변수에 넣어둠

    void Start()
    {
        InvokeRepeating("MakeSquare", 0f, 1f);   // 함수이름, 언제실행시킬건지(바로 실행시 0f), 얼마만큼 자주 실행시킬건지
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MakeSquare()
    {
        Instantiate(square);    //스퀘어 프리팹 생성 
    }
}
