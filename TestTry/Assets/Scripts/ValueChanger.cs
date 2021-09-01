using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueChanger : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    public void IncreaseVolume()
    {
        Debug.Log("Повышаем");
        var fade1 = StartCoroutine(FadeIn(1, 0.01f));
    }

    public void FadeOutVolume()
    {
        Debug.Log("Понижаем");
        var fade2 = StartCoroutine(FadeIn(0, 0.07f));
    }

    //public void ChangeVolume()
    //{
    //    Debug.Log("Повышаем");
    //    var fade1 = StartCoroutine(FadeIn(1, 0.01f));

    //    Debug.Log("Понижаем");
    //    var fade2 = StartCoroutine(FadeIn(0, 0.2f));
    //}

    private IEnumerator FadeIn(float target, float maxDelta)
    {
        while (_audioSource.volume != target)
        {
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, target, maxDelta);
            Debug.Log("выход из цикла yield");
            yield return null;

        }

        Debug.Log("выход из цикла");
    }
}