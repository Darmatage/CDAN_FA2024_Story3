using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseThisFile : MonoBehaviour
{
	public GameObject thisFile;

    public void CloseFile()
    {
        thisFile.SetActive(false);
    }
}
