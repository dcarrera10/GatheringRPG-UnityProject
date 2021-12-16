
using UnityEngine;

    [System.Serializable]
public class Stat : MonoBehaviour
{
    [SerializeField]
    private int baseValue;

    // Used to add modifier but not yet implemented
    public int GetValue ()
    {
        return baseValue;
    }

}
