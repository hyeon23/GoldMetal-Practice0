using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEvent : MonoBehaviour
{
    //1. ���� ������ �浹�� �߻��ϴ� �̺�Ʈ 3����
    private void OnCollisionEnter(Collision collision){ }
    private void OnCollisionExit(Collision collision) { }
    private void OnCollisionStay(Collision collision) { }
    //2. �ݶ��̴� �浹�� �߻��ϴ� �̺�Ʈ 3����
    private void OnTriggerEnter(Collider other) { }
    private void OnTriggerExit(Collider other) { }
    private void OnTriggerStay(Collider other) { }
}
