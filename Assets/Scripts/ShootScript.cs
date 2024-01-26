using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShootScript : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject smoke;
    public TextMeshProUGUI scoreText;



    int score = 0;
    public void Shoot()
    {
        RaycastHit hit;
       
        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if (hit.transform.name=="balloon1(Clone)" || hit.transform.name=="balloon2(Clone)" || hit.transform.name == "balloon3(Clone)")
            {
                Destroy(hit.transform.gameObject);
                score++;
                scoreText.text = score.ToString();
                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
            }
        }
    }
}
