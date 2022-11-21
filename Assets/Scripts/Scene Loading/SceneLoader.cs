using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private GameObject _loadingScreen;

    public static SceneLoader Instance { get; private set; }

    private void Awake()
    {
        if(FindObjectsOfType<SceneLoader>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void LoadScene(int scene)
    {
        StartCoroutine(LoadSceneRoutine(scene));
    }

    private IEnumerator LoadSceneRoutine(int scene)
    {
        _loadingScreen.SetActive(true);

        yield return SceneManager.LoadSceneAsync(scene);

        _loadingScreen.SetActive(false);
    }
}
