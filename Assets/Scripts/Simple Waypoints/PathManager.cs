using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathManager : MonoBehaviour
{
    [SerializeField] private Path[] _paths;

    private Queue<Path> _pathsQueue;

    private Path _currentPath;


    private void Awake()
    {
        _pathsQueue = new Queue<Path>(_paths);
    }

    private void Start()
    {
        ShowNextPath();
    }

    public void ShowNextPath()
    {
        _currentPath?.HidePoints();

        if (_pathsQueue.TryDequeue(out Path path))
        {
            _currentPath = path;
            _currentPath.ShowPoints();
        }
    }
}
