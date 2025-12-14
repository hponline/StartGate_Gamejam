using TMPro;
using UnityEngine;

public class FloatingTxt : MonoBehaviour
{
    [SerializeField] float moveUpSpeed = 1f;
    [SerializeField] float lifeTime = 1f;

    TextMeshProUGUI text;

    void Awake()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void SetText(float value)
    {
        text.text = value.ToString();
    }

    void Update()
    {
        transform.position += Vector3.up * moveUpSpeed * Time.deltaTime;
        lifeTime -= Time.deltaTime;

        if (lifeTime <= 0f)
            Destroy(gameObject);
    }
}
