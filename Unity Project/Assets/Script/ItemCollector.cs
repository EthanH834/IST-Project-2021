using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    private int gems = 0;

    [SerializeField] private TMP_Text gemsText;
    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("gem"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            gems++;
            gemsText.text = "GEMS: " + gems;
        }
    }
}