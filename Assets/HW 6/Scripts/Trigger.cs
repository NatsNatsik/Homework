using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{  
    int Count = 0;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("������ ���� 1");
        other.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -30),ForceMode.Impulse);
        Count++;

        if (Count == 3)
        {
            Debug.Log("���� ���� � ����� ������ 1");
            other.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 0), ForceMode.Impulse);
        }

    }
}
