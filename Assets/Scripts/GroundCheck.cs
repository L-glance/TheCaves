using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{

    //������� ����� ������� ��������� � ��� �����������
    public bool isGrounded ;
    public Transform groundCheck;
    private float groundDistance = 0.4f;
    public LayerMask groundLayerMask;


    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundLayerMask);
    }
}
