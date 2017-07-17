using System.Windows.Forms;
using UnityEngine;
using UnityEngine.UI;

public class ImportManager : MonoBehaviour {
    private GameObject importedObject;
    private const string USER_DIRECTORY = "%HOMEPATH%";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /**
     *  <summary>
     *  Import button's OnClickListener. This method calls the open file dialog method "GetPath()"
     *  and validate any errors with the file name returned. At last, import the object
     *  </summary>
     */
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

    /** 
     * <summary>It tries to import the object specified in the <param name="path">path</param> argument</summary>
     */
    int ImportObject(string path) {
        int code = Errors.NO_ERRORS;

        // Validating the filename
        if (path == "") {
            code = Errors.ON_IMPORT_PATH_EMPTY;
        } else {
        }
        return code;
    }

    string GetPath() {
        OpenFileDialog dialog = new OpenFileDialog();
        if (dialog.ShowDialog() == DialogResult.OK || dialog.FileName.Length > 0) {
            Debug.Log("File received: " + dialog.FileName);
        } else {
            Debug.LogWarning(Errors._MAP[Errors.ON_IMPORT_UNCAUGHT_ERROR]);
        }
        return dialog.FileName;
    }
}
