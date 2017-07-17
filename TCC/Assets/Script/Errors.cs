using System.Collections.Generic;

public class Errors {
    public const int NO_ERRORS                      = 0x0000;
    public const int ON_IMPORT_PATH_EMPTY           = 0x0001;
    public const int ON_IMPORT_FILE_NOT_FOUND       = 0x0002;
    public const int ON_IMPORT_FILE_NOT_SUPPORTED   = 0x0003;
    public const int ON_IMPORT_UNCAUGHT_ERROR       = 0x0004;

    public static Dictionary<int, string> _MAP = new Dictionary<int, string>()
    {
        { NO_ERRORS,                    ErrorsMessages._MAP["NO_ERRORS"] },
        { ON_IMPORT_FILE_NOT_FOUND,     ErrorsMessages._MAP["ON_IMPORT_FILE_NOT_FOUND"] },
        { ON_IMPORT_PATH_EMPTY,         ErrorsMessages._MAP["ON_IMPORT_PATH_EMPTY"] },
        { ON_IMPORT_FILE_NOT_SUPPORTED, ErrorsMessages._MAP["ON_IMPORT_FILE_NOT_SUPPORTED"] },
        { ON_IMPORT_UNCAUGHT_ERROR,     ErrorsMessages._MAP["ON_IMPORT_UNCAUGHT_ERROR"] }
    };
}
