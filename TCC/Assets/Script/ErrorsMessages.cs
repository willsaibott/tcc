
using System.Collections.Generic;

public class ErrorsMessages {
    public static Dictionary<string, string> _MAP = new Dictionary<string, string>() {
        { "NO_ERRORS",                      "The process was completed sucessfully" },
        { "ON_IMPORT_PATH_EMPTY",           "The \"Path\" is empty, please inform a valid file path" },
        { "ON_IMPORT_FILE_NOT_FOUND",       "The \"File\" was not found!" },
        { "ON_IMPORT_FILE_NOT_SUPPORTED",   "The \"Imported File\" is not supported. please inform an object of type .obj, .3d" }
    };
}
