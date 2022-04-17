using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int breakableBlocks; // Serialized for debugging purposes

    ScenceLoader scenceLoader;
    private void Start()
    {
        scenceLoader = FindObjectOfType<ScenceLoader>();
    }

    public void CountBlocks()
    {
        breakableBlocks++;
    }
    public void BlockDestroyed()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            scenceLoader.LoadNextScence();
        }
    }

}
