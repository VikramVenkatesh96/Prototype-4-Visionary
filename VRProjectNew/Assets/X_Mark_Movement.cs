using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X_Mark_Movement : MonoBehaviour
{
    private Vector3 initial_Position;
    private float bot_Y_Position;
    private Vector3 bot_Position;
    private float top_Y_Position;
    private Vector3 top_Position;
    private float difference_Movement;
    private float trans_Speed;

    void Start()
    {
        trans_Speed = 0.001f;
        difference_Movement = 0.1f;
        initial_Position = this.gameObject.transform.position;
        bot_Y_Position = this.gameObject.transform.position.y + difference_Movement;
        top_Y_Position = this.gameObject.transform.position.y - difference_Movement;
        bot_Position = this.gameObject.transform.position + new Vector3(0, bot_Y_Position, 0);
        top_Position = this.gameObject.transform.position + new Vector3(0, top_Y_Position, 0);
    }


    void LateUpdate()
    {
        this.gameObject.transform.position = Vector3.Lerp(top_Position, bot_Position, trans_Speed);
    }
}
