using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //메인카메라main, 스크린의 위치를 게임월드상의 위치로 바꿔주는 ScreenToWorldPoint, 바꿔줘야할 위치=마우스의 위
        Vector2 mousePos =  Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Unity의 transform값은 transform을 통해 불러옴. position이 transform에 있기 때문에
        transform.position = mousePos;
    }
}
