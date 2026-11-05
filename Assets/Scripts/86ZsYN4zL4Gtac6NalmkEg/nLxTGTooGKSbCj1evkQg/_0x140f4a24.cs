using UnityEngine;

public class _0x140f4a24 : MonoBehaviour
{
    private void _0xb1042b34()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public static _0x140f4a24 Instance;
    public bool IsOnlyWinGameEndEnabled;
    public bool IsSkipSplashEnabled;
    public bool IsTutorialEnabled;
    public bool IsLevelSelectorEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0x140f4a24>();
            DontDestroyOnLoad(this.gameObject);
            this._0xb1042b34();
        }
        else
        {
            this._0x6ec49e60();
            Destroy(this.gameObject);
        }
    }

    public bool IsLevelIncrementOnWin;
    public bool IsBestScoreEnabled;
    private void _0x6ec49e60()
    {
    }

    public bool IsCheckScoreEnabled;
    public bool IsStoryEnabled;
    public bool IsTimerEnabled;
}