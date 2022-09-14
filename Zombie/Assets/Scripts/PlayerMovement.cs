using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����� �Է¿� ���� �÷��̾� ĳ���͸� �����̴� ��ũ��Ʈ
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // �յ� �������� �ӵ�
    public float rotateSpeed = 180f; // �¿� ȸ�� �ӵ�

    private PlayerInput playerInput; // �÷��̾� �Է��� �˷��ִ� ������Ʈ

    private Rigidbody playerRigidbody; // �÷��̾� ĳ������ ������ٵ�
    private Animator playerAnimator; // �÷��̾� ĳ������ �ִϸ�����

    void Start()
    {
        // ����� ������Ʈ���� ���� ��������
        playerInput = GetComponent<PlayerInput>();
        
    }

    // FixedUpdate�� ���� ���� �ֱ⿡ ���� �����
    private void FixedUpdate()
    {
        // ���� ���� �ֱ⸶�� ������, ȸ��, �ִϸ��̼� ó�� ����
        Debug.Log($"Vertical : {playerInput.move}");
        Debug.Log($"Horizontal : {playerInput.rotate}");
    }

    // �Է°��� ���� ĳ���͸� �յڷ� ������
    private void Move()
    {

    }

    // �Է°��� ���� ĳ���͸� �¿�� ȸ��
    private void Rotate()
    {

    }
}
