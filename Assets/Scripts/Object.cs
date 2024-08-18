using System.Collections;
using UnityEngine;

public class Object : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private KeyCode moveForwardKey;
    [SerializeField]
    private KeyCode moveBackKey;
    [SerializeField]
    private KeyCode moveLeftKey;
    [SerializeField]
    private KeyCode moveRightKey;

    [SerializeField]
    private float destroyTime;

    [SerializeField]
    private bool delayDestroy;
    public bool DelayDestroy
    {
        get
        {
            return delayDestroy;
        }
        set
        {
            delayDestroy = value;
        }
    }

    private IEnumerator Start()
    {
        if (delayDestroy)
        {
            Destroy(gameObject, destroyTime);
        }

        while (true)
        {
            float inputForward = Input.GetKey(moveForwardKey) ? 1 : 0;
            float inputBack = Input.GetKey(moveBackKey) ? 1 : 0;
            float inputLeft = Input.GetKey(moveLeftKey) ? 1 : 0;
            float inputRight = Input.GetKey(moveRightKey) ? 1 : 0;

            Vector3 direction = (Vector3.right * (inputRight - inputLeft)) + (Vector3.forward * (inputForward - inputBack));

            transform.position += direction.normalized * speed * Time.deltaTime;

            yield return null;
        }
    }
}
