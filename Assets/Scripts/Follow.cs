using System.Collections;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField]
    private Camera camera;

    [SerializeField]
    private Transform target;

    [SerializeField]
    private float distance;

    private bool isFollow;
    public bool IsFollow
    {
        get
        {
            return isFollow;
        }
        set
        {
            isFollow = value;
        }
    }

    private void Awake()
    {
        if (camera != null)
        {
            camera = Camera.main;
        }
    }

    private IEnumerator Start()
    {
        while (true)
        {
            if (isFollow)
            {
                if (target != null)
                {
                    transform.position = new Vector3(target.position.x, target.position.y, target.position.z - distance);
                }
            }

            yield return null;
        }
    }
}
