using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x6ef2d260 : MonoBehaviour
{
    private Vector3 _0x539588b2 { get; set; }

    private new Camera _0xf077a429;
    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x52655f81;
        Matrix4x4 _0x65b4164f = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0xf077a429.orthographic)
        {
            float _0x401c209e = this._0xf077a429.farClipPlane - this._0xf077a429.nearClipPlane;
            float _0x1c4cb10c = (this._0xf077a429.farClipPlane + this._0xf077a429.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x1c4cb10c), new Vector3(this._0xf077a429.orthographicSize * 2 * this._0xf077a429.aspect, this._0xf077a429.orthographicSize * 2, _0x401c209e));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0xf077a429.fieldOfView, this._0xf077a429.farClipPlane, this._0xf077a429.nearClipPlane, this._0xf077a429.aspect);
        }

        Gizmos.matrix = _0x65b4164f;
    }

    private Vector3 _0x9cefa39a { get; set; }
    private float _0x330d98a9 { get; set; }
    private Vector3 _0x3bbcd5ef { get; set; }
    private Vector3 _0x8c784f20 { get; set; }
    private Vector3 _0x0a7f595d { get; set; }
    private Vector3 _0x554ad2ad { get; set; }
    private Vector3 _0xc6241c45 { get; set; }

    private float _0x51d4e87c = 1;
    private Vector3 _0xba3f8fa7 { get; set; }

    private Color _0x52655f81 = Color.white;
    private static _0x6ef2d260 _0x5fb27554;
    //public bool executeInUpdate;
    private float _0x68afca27 { get; set; }

    public enum _0xa8d2a713
    {
        Landscape,
        Portrait
    }

    private void _0x25f9ebad()
    {
        float _0xcc65f0da, _0x3987b483, _0x9bb8ed1d, _0xd9c615c2;
        if (this._0x69b98a7d == _0xa8d2a713.Landscape)
            this._0xf077a429.orthographicSize = 1f / this._0xf077a429.aspect * this._0x51d4e87c / 2f;
        else
            this._0xf077a429.orthographicSize = this._0x51d4e87c / 2f;
        this._0x330d98a9 = 2f * this._0xf077a429.orthographicSize;
        this._0x68afca27 = this._0x330d98a9 * this._0xf077a429.aspect;
        float _0x0c904d7a = this._0xf077a429.transform.position.x;
        float _0x743c32a7 = this._0xf077a429.transform.position.y;
        _0xcc65f0da = _0x0c904d7a - this._0x68afca27 / 2;
        _0x3987b483 = _0x0c904d7a + this._0x68afca27 / 2;
        _0x9bb8ed1d = _0x743c32a7 + this._0x330d98a9 / 2;
        _0xd9c615c2 = _0x743c32a7 - this._0x330d98a9 / 2;
        this._0x554ad2ad = new Vector3(_0xcc65f0da, _0xd9c615c2, 0);
        this._0x8c784f20 = new Vector3(_0x0c904d7a, _0xd9c615c2, 0);
        this._0x539588b2 = new Vector3(_0x3987b483, _0xd9c615c2, 0);
        this._0x9cefa39a = new Vector3(_0xcc65f0da, _0x743c32a7, 0);
        this._0x0a7f595d = new Vector3(_0x0c904d7a, _0x743c32a7, 0);
        this._0x8609e3ee = new Vector3(_0x3987b483, _0x743c32a7, 0);
        this._0xba3f8fa7 = new Vector3(_0xcc65f0da, _0x9bb8ed1d, 0);
        this._0x3bbcd5ef = new Vector3(_0x0c904d7a, _0x9bb8ed1d, 0);
        this._0xc6241c45 = new Vector3(_0x3987b483, _0x9bb8ed1d, 0);
    }

    private void Awake()
    {
        this._0xf077a429 = this.GetComponent<Camera>();
        _0x5fb27554 = this;
        this._0x25f9ebad();
    }

    private Vector3 _0x8609e3ee { get; set; }

    private _0xa8d2a713 _0x69b98a7d = _0xa8d2a713.Portrait;
}