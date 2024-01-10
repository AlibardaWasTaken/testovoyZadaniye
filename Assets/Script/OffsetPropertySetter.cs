
using UnityEngine;

public class OffsetPropertySetter : MonoBehaviour
{
    [SerializeField]
    private float _offsetX;
    [SerializeField]
    private float _offsetY;

    private MaterialPropertyBlock _propertyBlock;

    public void Start()
    {
        OnValidate();
        Destroy(this);
    }



    void OnValidate()
    {

        if (_propertyBlock == null)
            _propertyBlock = new MaterialPropertyBlock();

        Renderer renderer = GetComponentInChildren<Renderer>();

       _propertyBlock.SetVector("_BaseMap_ST", new Vector4(0.33f, 0.2f, _offsetX, _offsetY));

        renderer.SetPropertyBlock(_propertyBlock);
    }
}
