namespace AspNetPro.Blog.Models.ViewModels;

public record PostItemListViewModel
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Summary { get; set; }
    public string? PublishedOn { get; set; }
}
