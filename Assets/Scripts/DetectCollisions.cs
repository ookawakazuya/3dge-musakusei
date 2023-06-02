using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameObject player;
    private PlayerController pc;
    [SerializeField] int point;
    private void OnTriggerEnter(Collider other) {
        player = GameObject.Find("Player");
        pc = player.GetComponent<PlayerController>();
        pc.SetCountText(point);
        Destroy(gameObject);//�A�^�b�`����Ă��鎩�����g������
        Destroy(other.gameObject);//�Ԃ���������iother�j������
    }
}
