using System;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    [SerializeField] private Icon[] icons;
    [SerializeField] private Image iconImage;
    [SerializeField] private TMP_Text titleText;
    [SerializeField] private TMP_Text descriptionText;
    [SerializeField] private TMP_Text priceText;
    private Button button;
    private Product product;
    private Action<string> onSelect;

    public ShopItem Init(Product product, Action<string> onSelect)
    {
        this.product = product;
        this.onSelect = onSelect;
        button = GetComponent<Button>();
        iconImage.sprite = icons.FirstOrDefault(icon => icon.id == product.definition.id).sprite;
        titleText.text = product.metadata.localizedTitle;
        priceText.text = product.metadata.localizedPriceString;
        descriptionText.text = product.metadata.localizedDescription;
        button.interactable = !product.hasReceipt;
        return this;

    }

    public void OnClick()
    {
        onSelect?.Invoke(product.definition.id);
    }
}

[Serializable]
class Icon
{
    public string id;
    public Sprite sprite;
}