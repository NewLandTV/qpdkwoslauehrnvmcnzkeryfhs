using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        Follow[] follows = FindObjectsOfType<Follow>();

        for (int i = 0; i < follows.Length; i++)
        {
            follows[i].IsFollow = true;
        }
    }
}
