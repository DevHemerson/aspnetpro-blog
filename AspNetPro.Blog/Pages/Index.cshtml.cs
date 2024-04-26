using AspNetPro.Blog.Infrastructure.Data;
using AspNetPro.Blog.Models.entities;
using AspNetPro.Blog.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetPro.Blog.Pages
{
    public class IndexModel(BlogContext blogContext) : PageModel
    {
        public IList<PostItemListViewModel> Posts { get; set; }
        public void OnGet()
        {
            this.Posts =  blogContext.Posts
                .OrderByDescending(p => p.PublishedOn)
                .Select(x => new PostItemListViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    Summary = x.Summary,
                    PublishedOn = x.PublishedOn.Value.ToShortDateString(),
                })
                .ToList();
        }
    }
}
