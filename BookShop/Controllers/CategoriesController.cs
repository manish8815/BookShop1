using AutoMapper;
using BookShop.Data;
using BookShop.DTOs;
using BookShop.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public CategoriesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoryDTO>>> Get()
        {
            var categories = await _context.Categories.OrderBy(x => x.Name).ToListAsync();
            return _mapper.Map<List<CategoryDTO>>(categories);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<CategoryDTO>> Get(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return _mapper.Map<CategoryDTO>(category);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CategoryCreationDTO categoryCreationDTO)
        {
            Category category = _mapper.Map<Category>(categoryCreationDTO);
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] CategoryCreationDTO categoryCreationDTO)
        {
            Category category = _mapper.Map<Category>(categoryCreationDTO);
            category.Id = id;
            //_context.Categories.Update(category);// below is the alternate code to update
            _context.Entry(category).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id, [FromBody] )
        {
            var category = _context.Categories.First(x => x.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }

}
}
