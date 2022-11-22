using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{
    [SerializeField] private VideoPlayer _player;


    private void Awake()
    {
        _player.loopPointReached += OnPlayEnd;
    }

    public void PlayeVideo(VideoClip clip)
    {
        StartCoroutine(PlayVideoRoutine(clip));
    }

    private void OnPlayEnd(VideoPlayer source)
    {
        StartCoroutine(HideVideoPlayer());
    }

    private IEnumerator PlayVideoRoutine(VideoClip clip)
    {
        yield return ShowVideoPlayer();

        _player.clip = clip;
        _player.Play();
    }

    private IEnumerator ShowVideoPlayer()
    {
        _player.gameObject.SetActive(true);

        WaitForSeconds wait = new WaitForSeconds(0.02f);

        Vector3 scale = new Vector3(0, 0, 0);

        while (scale.x < 1)
        {
            scale.Set(scale.x + (1 * 0.02f), scale.y + (1 * 0.02f), scale.y + (1 * 0.02f));
            _player.transform.localScale = scale;
            yield return wait;
        }
    }

    private IEnumerator HideVideoPlayer()
    {
        WaitForSeconds wait = new WaitForSeconds(0.02f);

        Vector3 scale = new Vector3(0, 0, 0);

        while (scale.x > 0)
        {
            scale.Set(scale.x - (1 * 0.02f), scale.y - (1 * 0.02f), scale.y - (1 * 0.02f));
            _player.transform.localScale = scale;
            yield return wait;
        }

        _player.gameObject.SetActive(false);
    }
}
