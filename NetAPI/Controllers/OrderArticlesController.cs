using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GestionInventaireWebApp.Models.BDD;

namespace NetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderArticlesController : ControllerBase
    {
        private readonly NetContext _context;

        public OrderArticlesController(NetContext context)
        {
            _context = context;
        }

        // GET: api/OrderArticles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderArticle>>> GetOrderArticles()
        {
            return await _context.OrderArticles.ToListAsync();
        }

        // GET: api/OrderArticles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderArticle>> GetOrderArticle(int id)
        {
            var orderArticle = await _context.OrderArticles.FindAsync(id);

            if (orderArticle == null)
            {
                return NotFound();
            }

            return orderArticle;
        }

        // PUT: api/OrderArticles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderArticle(int id, OrderArticle orderArticle)
        {
            if (id != orderArticle.ArticleId)
            {
                return BadRequest();
            }

            _context.Entry(orderArticle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderArticleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/OrderArticles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderArticle>> PostOrderArticle(OrderArticle orderArticle)
        {
            _context.OrderArticles.Add(orderArticle);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (OrderArticleExists(orderArticle.ArticleId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }


            return CreatedAtAction(nameof(GetOrderArticle), new { id = orderArticle.ArticleId }, orderArticle);

        }

        // DELETE: api/OrderArticles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderArticle(int id)
        {
            var orderArticle = await _context.OrderArticles.FindAsync(id);
            if (orderArticle == null)
            {
                return NotFound();
            }

            _context.OrderArticles.Remove(orderArticle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderArticleExists(int id)
        {
            return _context.OrderArticles.Any(e => e.ArticleId == id);
        }
    }
}
