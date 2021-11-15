
using UnityEngine;

    [System.Serializable]
public class Stat : MonoBehaviour
{
    [SerializeField]
    private int baseValue;

    public int GetValue ()
    {
        return baseValue;
    }

}
