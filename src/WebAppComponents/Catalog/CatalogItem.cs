namespace eShop.WebAppComponents.Catalog;

public record CatalogItem(
    int Id,
    string Name,
    string Description,
    decimal Price,
    string PictureUrl,
    int CatalogBrandId,
    CatalogBrand CatalogBrand,
    int CatalogTypeId,
    CatalogItemType CatalogType);

public record CatalogResult(int PageIndex, int PageSize, int Count, List<CatalogItem> Data);
public record CatalogBrand(int Id, string Brand);
public record CatalogItemType(int Id, string Type);

public class CatalogItemObject
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string PictureUrl { get; set; }
    public int CatalogBrandId { get; set; }
    public CatalogBrand CatalogBrand { get; set; }
    public int CatalogTypeId { get; set; }
    public CatalogItemType CatalogType { get; set; }

    public CatalogItemObject(CatalogItem item)
    {
        Id = item.Id;
        Name = item.Name;
        Description = item.Description;
        Price = item.Price;
        PictureUrl = item.PictureUrl;
        CatalogBrandId = item.CatalogBrandId;
        CatalogBrand = item.CatalogBrand;
        CatalogTypeId = item.CatalogTypeId;
        CatalogType = item.CatalogType;
    }
}
