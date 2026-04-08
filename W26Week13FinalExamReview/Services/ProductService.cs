using Microsoft.EntityFrameworkCore;
using W26Week13FinalExamReview.Data;
using W26Week13FinalExamReview.Models;

namespace W26Week13FinalExamReview.Services
{
    public class ProductService
    {
        private ProductContext _context;

        public ProductService(ProductContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<List<Product>> GetProductsAsync(string? searchKeyword = null)
        {
            var products = _context.Products
                                   .Include(p => p.Category)
                                   .AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchKeyword))
            {
                products = products.Where(p => p.ProductName.Contains(searchKeyword));
            }

            return await products.ToListAsync();
        }

        public async Task<List<Product>> GetProductsByCategoryAsync(int catId)
        {
            var products = _context.Products
                                   .Include(p => p.Category)
                                   .AsQueryable();

            if (catId > 0)
            {
                products = products.Where(p => p.CategoryId == catId);
            }

            return await products.ToListAsync();
        }
    }
}
