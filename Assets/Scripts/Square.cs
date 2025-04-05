using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 시작 위치 랜덤
        float x = Random.Range(-3.0f, 3.0f); // 최솟값, 최댓값
        float y = Random.Range(3.0f, 5.0f);

        transform.position = new Vector2(x, y);  //x값, y값

        // 스퀘어 사이즈 랜덤
        float size = Random.Range(0.5f, 1.5f);
        transform.localScale = new Vector2(size, size); // size아니고 localScale해야 size에 접근가능/ x값, y값 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
