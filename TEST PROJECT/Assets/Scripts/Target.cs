using UnityEngine;

public class Target : MonoBehaviour, ITarget
{
    public Vector3 GetPosition()
    {
        return transform.position;
    }
    public new int GetInstanceID()
    {
        return gameObject.GetInstanceID();
    }
}
