using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEvent : MonoBehaviour
{
    //1. 실제 물리적 충돌로 발생하는 이벤트 3가지
    private void OnCollisionEnter(Collision collision){ }
    private void OnCollisionExit(Collision collision) { }
    private void OnCollisionStay(Collision collision) { }
    //2. 콜라이더 충돌로 발생하는 이벤트 3가지
    private void OnTriggerEnter(Collider other) { }
    private void OnTriggerExit(Collider other) { }
    private void OnTriggerStay(Collider other) { }
}
