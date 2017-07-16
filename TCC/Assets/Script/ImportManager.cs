using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportManager : MonoBehaviour {
    private GameObject importedObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnImportObject() {
        Debug.Log("Importing Object");

        string path = GetPath();
        int    code = ImportObject(path);

        if (code == Errors.NO_ERRORS) {
            Debug.Log(Errors._MAP[Errors.NO_ERRORS]);
        } else {
            Debug.LogError(Errors._MAP[code]);
        }
    }

    int ImportObject(string path) {
        int code = Errors.NO_ERRORS;
        if (path == "") {
            code = Errors.ON_IMPORT_PATH_EMPTY;
        }
        return code;
    }

    string GetPath() {
        return "";
    }


}
