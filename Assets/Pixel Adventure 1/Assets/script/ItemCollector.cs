using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int kiwies = 0;

    [SerializeField] private Text ScoreText;
    [SerializeField] private AudioSource CollectingSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Kiwi"))
        {
            CollectingSoundEffect.Play();
            Destroy(collision.gameObject);
            kiwies++;
            ScoreText.text = "Score: " + kiwies;
        }
    }


}
