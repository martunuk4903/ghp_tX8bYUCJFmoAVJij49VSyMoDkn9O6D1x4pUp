using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x467962b5 : MonoBehaviour
{
    public List<Button> HomeButtons = new();
    public int CustomTimeInitial = 30;
    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0x888e2df9;
        this.CurrentGameIndex = _0xe6558cf1.Instance._0x0101eb58;
        foreach (Button _0x413de185 in this.HomeButtons)
            _0x413de185.onClick.AddListener(() =>
            {
                this._0x07de099a();
            });
        foreach (Button _0xb4db4c5a in this.PauseButtons)
            _0xb4db4c5a.onClick.AddListener(() =>
            {
                _0xe6558cf1.Instance._0x9833778c(false);
                _0x4751f1e9.Instance._0xf4b7ab90(_0xec7175f7._0x5d5037c6.PAUSE);
            });
        this._0x299d4731();
        this.LevelNumberText.ForEach(_0xdd47c0e3 => _0xdd47c0e3.text = $"LVL {_0xe6558cf1._0x20cea244._0xc3ef5863 + 1}");
        if (_0x140f4a24.Instance.IsTimerEnabled)
        {
            this._0xad3ce576();
            this.StartCoroutine(this._0x7b78fe98());
        }
    }

    public List<Button> PauseButtons = new();
    public List<TMP_Text> LevelNumberText = new();
    private static _0x467962b5 _0x673d67ab;
    public void _0xacbb9f7f()
    {
        if (!this.IsGameEnd)
        {
            this._0x206211a5();
            _0xe6558cf1.IsAfterLevelComplete = true;
            _0xe6558cf1.IsAfterLevelFailed = false;
            _0x42700195 _0xb03ee70e = _0x4751f1e9.Instance._0x3b81ecb8(_0xec7175f7._0x5d5037c6.WIN).GetComponent<_0x42700195>();
            if (_0x140f4a24.Instance.IsCheckScoreEnabled)
                _0xb03ee70e.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x56b6f473}";
            else
                _0xb03ee70e.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x140f4a24.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0xec7175f7._0x05354bf3._0x2869e359)
                    _0xec7175f7._0x05354bf3._0x2869e359 = this.ScoreCurrent;
                _0xb03ee70e.ContentAdditionalText.text = $"{_0xec7175f7._0x05354bf3._0x2869e359}";
            }
            else
            {
                _0xb03ee70e.ContentAdditionalText.text = $"{this._0x652638ee}";
                _0xec7175f7._0x05354bf3._0x2869e359 += this._0x652638ee;
            }

            if (_0x140f4a24.Instance.IsLevelIncrementOnWin)
                ++_0xe6558cf1._0x20cea244._0xc3ef5863;
            _0x4751f1e9.Instance._0xf4b7ab90(_0xec7175f7._0x5d5037c6.WIN);
        }
    }

    private IEnumerator _0x7b78fe98()
    {
        this._0xad3ce576();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0xe6558cf1.Instance._0x0101eb58 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0xe6558cf1.Instance._0x04b70943)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0xad3ce576();
            }
        }

        if (!this.IsGameEnd)
            this._0x5f7ed6e2();
    }

    [HideInInspector]
    public int TimeLeft;
    private void _0xad3ce576()
    {
        this.TimerText.ForEach(_0xdd47c0e3 => _0xdd47c0e3.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x9f886152._0x45108885(new byte[6] { 187, 187, 138, 236, 165, 165 }, 214)));
    }

    private int _0x888e2df9 => this.CustomTimeInitial + _0xe6558cf1._0x20cea244._0xc3ef5863 * 10;

    public int CustomTargetScore = 10;
    public List<TMP_Text> SubtitleText = new();
    [HideInInspector]
    public bool IsGameEnd;
    private void _0x299d4731()
    {
        if (_0x140f4a24.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0xdd47c0e3 => _0xdd47c0e3.text = $"{this.ScoreCurrent}/{this._0x56b6f473}");
        else
            this.ScoreText.ForEach(_0xdd47c0e3 => _0xdd47c0e3.text = $"{this.ScoreCurrent}");
    }

    public List<TMP_Text> TimerText = new();
    [HideInInspector]
    public int ScoreCurrent;
    private int _0x652638ee => this.ScoreCurrent;

    private void _0xff5d52e3()
    {
        if (this.ScoreCurrent >= this._0x56b6f473)
            this._0xacbb9f7f();
        else
            this._0x5f7ed6e2();
    }

    [HideInInspector]
    public int CurrentGameIndex;
    private void _0x4fb03362()
    {
        if (this.ScoreCurrent > _0xe6558cf1._0x20cea244._0xa151112d)
            _0xe6558cf1._0x20cea244._0xa151112d = this.ScoreCurrent;
        if (_0x140f4a24.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0x56b6f473)
                this._0xacbb9f7f();
    }

    private int _0x56b6f473 => this.CustomTargetScore + _0xe6558cf1._0x20cea244._0xc3ef5863 * 10;

    public void _0x5f7ed6e2()
    {
        if (_0x140f4a24.Instance.IsOnlyWinGameEndEnabled)
            this._0xacbb9f7f();
        if (!this.IsGameEnd)
        {
            this._0x206211a5();
            _0xe6558cf1.IsAfterLevelComplete = false;
            _0xe6558cf1.IsAfterLevelFailed = true;
            _0x42700195 _0x3b3d6c82 = _0x4751f1e9.Instance._0x3b81ecb8(_0xec7175f7._0x5d5037c6.LOSE).GetComponent<_0x42700195>();
            if (_0x140f4a24.Instance.IsCheckScoreEnabled)
                _0x3b3d6c82.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x56b6f473}";
            else
                _0x3b3d6c82.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x3b3d6c82.ContentAdditionalText.text = $"{0}";
            _0xec7175f7._0x05354bf3._0x2869e359 += 0;
            _0x4751f1e9.Instance._0xf4b7ab90(_0xec7175f7._0x5d5037c6.LOSE);
        }
    }

    private void Awake()
    {
        _0x673d67ab = this.gameObject.GetComponent<_0x467962b5>();
    }

    public void _0xb7528d2e(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0x299d4731();
            this._0x4fb03362();
        }
    }

    public List<TMP_Text> ScoreText = new();
    private void _0x206211a5()
    {
        this.IsGameEnd = true;
        _0xe6558cf1.IsAfterLevelComplete = true;
    }

    public void _0x07de099a()
    {
        _0xe6558cf1.Instance._0x9833778c(true);
        _0xe6558cf1.Instance._0x96e69a76(_0xec7175f7._0x8c4ad123.SCENE_0);
    }
}

internal static class _0x9f886152
{
    internal static string _0x45108885(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}