using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueChanger : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    public void IncreaseVolume()
    {
        Debug.Log("��������");
        var fade1 = StartCoroutine(FadeIn(1, 0.01f));
    }

    public void FadeOutVolume()
    {
        Debug.Log("��������");
        var fade2 = StartCoroutine(FadeIn(0, 0.07f));
    }

    //public void ChangeVolume()
    //{
    //    Debug.Log("��������");
    //    var fade1 = StartCoroutine(FadeIn(1, 0.01f));

    //    Debug.Log("��������");
    //    var fade2 = StartCoroutine(FadeIn(0, 0.2f));
    //}

    private IEnumerator FadeIn(float target, float maxDelta)
    {
        while (_audioSource.volume != target)
        {
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, target, maxDelta);
            Debug.Log("����� �� ����� yield");
            yield return null;

        }

        Debug.Log("����� �� �����");
    }
}