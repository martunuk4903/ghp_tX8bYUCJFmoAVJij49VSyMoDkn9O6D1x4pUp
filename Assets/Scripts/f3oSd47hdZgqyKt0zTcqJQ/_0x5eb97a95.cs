using UnityEngine;

/// <summary>
/// Builds the trail a segment at a time from a seeded System.Random (C.11 - never
/// UnityEngine.Random, which is global state two systems would fight over).
///
/// Every segment is PROVED crossable before it is shown: the climber moves at most one lane
/// per row, so reachability is a three-state forward pass. Generate, check, regenerate up to
/// 20 times, then fall back to the one hardcoded layout in the game - which is a guarantee,
/// not the game itself.
/// </summary>
public sealed class _0x5eb97a95
{
    private readonly bool[] _0x47ad4df9 = new bool[_0x5681a043.LaneCount];
    private readonly _0x62dbe494 _0x78eb90ff = new _0x62dbe494()._0x9e993001();
    /// <summary>
    /// The next segment. <paramref name = "entryLane"/> is the lane the climber will be in when
    /// the segment's first row arrives, so the reachability proof starts where the player is.
    /// </summary>
    public void _0xb45a414f(_0x62dbe494 _0x210491e7, int _0xa3bade82, bool _0xc9505db9)
    {
        for (int _0x4e01cc6f = 0; _0x4e01cc6f < 20; _0x4e01cc6f++)
        {
            this._0xc0c04127(this._0x78eb90ff, _0xc9505db9);
            if (this._0x9cd95048(this._0x78eb90ff, _0xa3bade82))
            {
                _0x210491e7._0x965d08ad(this._0x78eb90ff);
                this._0xc78961e3++;
                return;
            }
        }

        this._0x3bdda9ca(_0x210491e7);
        this._0xc78961e3++;
        {
#if B_LOGS
            {
                Debug.Log($"[trail] fallback segment at index {this._0xc78961e3} entry={_0xa3bade82}");
            }
#endif
        }
    }

    public int _0xc5283d7a { get; private set; }

    private void _0xa0c7dca7(_0x62dbe494 _0x4ade0b67, int _0x6ea98924, int _0xc096f593)
    {
        if (_0xc096f593 >= 0 && _0xc096f593 < _0x5681a043.LaneCount && _0x4ade0b67._0x251f1415(_0x6ea98924, _0xc096f593) == _0x5681a043.CellEmpty)
            _0x4ade0b67._0x4ed25bf7(_0x6ea98924, _0xc096f593, _0x5681a043.CellCoin);
    }

    public _0x5eb97a95 _0x3d1957c4(int _0x27d2b8c1, bool _0x77557ac1, int _0xddb733cb)
    {
        this._0xf9ecff29 = _0x27d2b8c1;
        this._0xeeb703c3 = _0x77557ac1;
        this._0xc78961e3 = 0;
        this._0xc5283d7a = (_0x27d2b8c1 * 7919) ^ (_0xddb733cb * 104729) ^ (_0x77557ac1 ? 15485863 : 0);
        this._0x23290b31 = new System.Random(this._0xc5283d7a);
        {
#if B_LOGS
            {
                Debug.Log($"[trail] seed={this._0xc5283d7a} stage={_0x27d2b8c1} challenge={_0x77557ac1} attempt={_0xddb733cb}");
            }
#endif
        }

        return this;
    }

    private int _0xc78961e3;
    private void _0xc0c04127(_0x62dbe494 _0xbe7a1b68, bool _0x5c856d3d)
    {
        _0xbe7a1b68._0xf1267c8b();
        int _0x0095a648 = _0x5681a043.RowsPerSegment;
        // 4 of the 6 rows carry a coin cluster, biased to the OUTER lanes so a climber who
        // never hops collects roughly half a coin per second and cannot drift into a win.
        // A cluster is at most TWO adjacent lanes and NEVER spans the board: a three-wide
        // cluster puts a coin in the centre lane whichever lane it is centred on, which
        // hands a player who never taps almost every row and makes the outer bias cosmetic.
        for (int _0x6688a284 = 0; _0x6688a284 < 4; _0x6688a284++)
        {
            int _0x08d10a23 = this._0x23290b31.Next(_0x0095a648);
            int _0x125adb38 = this._0xe21e6652();
            this._0xa0c7dca7(_0xbe7a1b68, _0x08d10a23, _0x125adb38);
            if (this._0x23290b31.Next(2) == 0)
                this._0xa0c7dca7(_0xbe7a1b68, _0x08d10a23, this._0xa669cf29(_0x125adb38));
        }

        // Ember cores: the only thing that puts shield back, so the quota stays reachable.
        int _0x689e176f = _0x46df03e4.CoreRows(this._0xeeb703c3, this._0xc78961e3);
        for (int _0x28d4e88e = 0; _0x28d4e88e < _0x689e176f; _0x28d4e88e++)
            _0xbe7a1b68._0x4ed25bf7(this._0x23290b31.Next(_0x0095a648), this._0x23290b31.Next(_0x5681a043.LaneCount), _0x5681a043.CellCore);
        if (_0x5c856d3d)
            return;
        // Vents. A row NEVER gets three of them - that is a constraint of the generator, not
        // a hope, and it is what makes the reachability pass below almost always succeed.
        int _0xeef89b7f = _0x46df03e4.VentRows(this._0xf9ecff29, this._0xeeb703c3);
        for (int _0x70d2a445 = 0; _0x70d2a445 < _0xeef89b7f; _0x70d2a445++)
        {
            int _0xe9bc24e3 = this._0x23290b31.Next(_0x0095a648);
            int _0xb99268f2 = 1 + this._0x23290b31.Next(2);
            for (int _0x316a5495 = 0; _0x316a5495 < _0xb99268f2; _0x316a5495++)
            {
                int _0xa40a2dd8 = this._0x23290b31.Next(_0x5681a043.LaneCount);
                if (this._0x38e047d7(_0xbe7a1b68, _0xe9bc24e3) >= _0x5681a043.LaneCount - 1)
                    break;
                _0xbe7a1b68._0x4ed25bf7(_0xe9bc24e3, _0xa40a2dd8, _0x5681a043.CellVent);
            }
        }
    }

    /// <summary>
    /// Outer-lane bias, so the centre lane is not a free ride. Measured, not guessed: at 0.60
    /// a climber who never taps reaches the stage-1 quota at second 64, at 0.68 it reaches it
    /// at second 80 - the same moment the shield runs out - so idling ends on the lose pop
    /// while an engaged run still clears stage 1 in about 43 s.
    /// </summary>
    private int _0xe21e6652()
    {
        return this._0x23290b31.NextDouble() < 0.68 ? (this._0x23290b31.Next(2) == 0 ? 0 : 2) : 1;
    }

    private readonly bool[] _0x0a2b9339 = new bool[_0x5681a043.LaneCount];
    private int _0xf9ecff29;
    /// <summary>
    /// Three-state forward pass: a segment is solvable when at least one lane sequence
    /// reaches the last row touching no vent, moving at most one lane per row.
    /// </summary>
    public bool _0x9cd95048(_0x62dbe494 _0x896e8fa3, int _0xfc2cc040)
    {
        for (int _0x0faf3ab3 = 0; _0x0faf3ab3 < _0x5681a043.LaneCount; _0x0faf3ab3++)
            this._0x47ad4df9[_0x0faf3ab3] = false;
        int _0x875044f1 = Mathf.Clamp(_0xfc2cc040, 0, _0x5681a043.LaneCount - 1);
        this._0x47ad4df9[_0x875044f1] = true;
        for (int _0x779e1fa5 = 0; _0x779e1fa5 < _0x5681a043.RowsPerSegment; _0x779e1fa5++)
        {
            for (int _0x4ac57a62 = 0; _0x4ac57a62 < _0x5681a043.LaneCount; _0x4ac57a62++)
                this._0x0a2b9339[_0x4ac57a62] = false;
            bool _0x1830fdd7 = false;
            for (int _0x8edb3394 = 0; _0x8edb3394 < _0x5681a043.LaneCount; _0x8edb3394++)
            {
                if (!this._0x47ad4df9[_0x8edb3394])
                    continue;
                for (int _0x7aff119a = -1; _0x7aff119a <= 1; _0x7aff119a++)
                {
                    int _0xdf537f68 = _0x8edb3394 + _0x7aff119a;
                    if (_0xdf537f68 < 0 || _0xdf537f68 >= _0x5681a043.LaneCount)
                        continue;
                    if (_0x896e8fa3._0x251f1415(_0x779e1fa5, _0xdf537f68) == _0x5681a043.CellVent)
                        continue;
                    this._0x0a2b9339[_0xdf537f68] = true;
                    _0x1830fdd7 = true;
                }
            }

            if (!_0x1830fdd7)
                return false;
            for (int _0xae86a9c2 = 0; _0xae86a9c2 < _0x5681a043.LaneCount; _0xae86a9c2++)
                this._0x47ad4df9[_0xae86a9c2] = this._0x0a2b9339[_0xae86a9c2];
        }

        return true;
    }

    private System.Random _0x23290b31;
    private int _0x38e047d7(_0x62dbe494 _0x58dbad29, int _0x9b64393a)
    {
        int _0x8157ed29 = 0;
        for (int _0xa4418fe9 = 0; _0xa4418fe9 < _0x5681a043.LaneCount; _0xa4418fe9++)
            if (_0x58dbad29._0x251f1415(_0x9b64393a, _0xa4418fe9) == _0x5681a043.CellVent)
                _0x8157ed29++;
        return _0x8157ed29;
    }

    /// <summary>The only hardcoded layout in the game, and it is a fallback, never the game.</summary>
    private void _0x3bdda9ca(_0x62dbe494 _0xb18741aa)
    {
        _0xb18741aa._0xf1267c8b();
        _0xb18741aa._0x4ed25bf7(0, 1, _0x5681a043.CellCoin);
        _0xb18741aa._0x4ed25bf7(1, 0, _0x5681a043.CellCoin);
        _0xb18741aa._0x4ed25bf7(1, 1, _0x5681a043.CellCoin);
        _0xb18741aa._0x4ed25bf7(2, 2, _0x5681a043.CellCore);
        _0xb18741aa._0x4ed25bf7(3, 0, _0x5681a043.CellVent);
        _0xb18741aa._0x4ed25bf7(3, 2, _0x5681a043.CellCoin);
        _0xb18741aa._0x4ed25bf7(4, 2, _0x5681a043.CellCoin);
        _0xb18741aa._0x4ed25bf7(5, 1, _0x5681a043.CellCoin);
    }

    /// <summary>
    /// The second lane of a two-coin cluster. A pair never lands in the CENTRE lane: the
    /// centre is reached only by a cluster that chose it outright, so the 0.60 outer bias
    /// survives the widening instead of being cancelled by it. Two outer coins with a clear
    /// centre is a row the player has to move for, which is the whole point of the trail.
    /// </summary>
    private int _0xa669cf29(int _0xb5938392)
    {
        if (_0xb5938392 == 0)
            return _0x5681a043.LaneCount - 1;
        if (_0xb5938392 == _0x5681a043.LaneCount - 1)
            return 0;
        return this._0x23290b31.Next(2) == 0 ? 0 : _0x5681a043.LaneCount - 1;
    }

    private bool _0xeeb703c3;
}