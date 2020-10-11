using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIApp.Data;
using WebAPIApp.Models;

namespace WebAPIApp.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            this._context = context;
        }
        public OperationResult Create(InputCategory model)
        {
            _context.Categories.Add(new Category
            {
                Name = model.Name
            });
            _context.SaveChanges();
            return OperationResult.Successed();
        }

        public OperationResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CategoryViewModel Find(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<CategoryViewModel> GetAll()
        {
            var result = _context.Categories.Select(c => new CategoryViewModel
            {
                Id = c.Id,
                Name = c.Name
            });
            return result;
            //Query >> Expression.Where().Skip(10).Take(10) >> Page 2.
            ///   ToList ForEach , FirstOrDefault , SingleOrDefault .Take
            ///   Access Data >> Execute Query
        }

        public OperationResult Update(int id, InputCategory model)
        {
            var selectedCategory = _context.Categories.Find(id);
            if (selectedCategory == null)
            {
                return OperationResult.NotFound();
            }

            selectedCategory.Name = model.Name;

            _context.Update(selectedCategory);
            _context.SaveChanges();
            return OperationResult.Successed();
        }
    }
}
