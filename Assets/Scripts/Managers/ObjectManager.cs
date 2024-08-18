using System.Collections;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    [SerializeField]
    private GameObject objectPrefab;

    [SerializeField]
    private Transform parent;

    [SerializeField]
    [Range(0, 999)]
    private int makeCount;

    private void Awake()
    {
        if (parent == null)
        {
            parent = transform;
        }

        for (int i = 0; i < makeCount; i++)
        {
            MakeObject();
        }
    }

    public Object MakeObject()
    {
        GameObject instance = Instantiate(objectPrefab, parent);

        Object objectComponent = instance.GetComponent<Object>();

        objectComponent.DelayDestroy = true;

        return objectComponent;
    }

    private IEnumerator Start()
    {
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                for (int i = 0; i < makeCount; i++)
                {
                    MakeObject();
                }
            }

            yield return null;
        }
    }
}
