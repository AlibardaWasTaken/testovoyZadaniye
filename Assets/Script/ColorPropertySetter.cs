using UnityEngine;

public class ColorPropertySetter : MonoBehaviour
{
    [SerializeField]
    private Color MaterialColor;


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

        _propertyBlock.SetColor("_BaseColor", MaterialColor);

        renderer.SetPropertyBlock(_propertyBlock);
    }
}