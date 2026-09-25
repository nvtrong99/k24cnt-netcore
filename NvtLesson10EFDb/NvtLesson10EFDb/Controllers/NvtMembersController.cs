
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NvtLesson10EFDb.Models;

public class NvtMembersController : Controller
{
    private readonly NvtK24cntt1lesson10EfdbContext _context;

    public NvtMembersController(NvtK24cntt1lesson10EfdbContext context)
    {
        _context = context;
    }

    // GET: NVTMEMBERS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.NvtMembers.ToListAsync());
    }

    // GET: NVTMEMBERS/Details/5
    public async Task<IActionResult> Details(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nvtmember = await _context.NvtMembers
            .FirstOrDefaultAsync(m => m.Id == id);
        if (nvtmember == null)
        {
            return NotFound();
        }

        return View(nvtmember);
    }

    // GET: NVTMEMBERS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: NVTMEMBERS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,NvtUseName,NvtPassword,NvtFullName,NvtEmail,NvtPhone,NvtStatus")] NvtMember nvtmember)
    {
        if (ModelState.IsValid)
        {
            _context.Add(nvtmember);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(nvtmember);
    }

    // GET: NVTMEMBERS/Edit/5
    public async Task<IActionResult> Edit(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nvtmember = await _context.NvtMembers.FindAsync(id);
        if (nvtmember == null)
        {
            return NotFound();
        }
        return View(nvtmember);
    }

    // POST: NVTMEMBERS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(long? id, [Bind("Id,NvtUseName,NvtPassword,NvtFullName,NvtEmail,NvtPhone,NvtStatus")] NvtMember nvtmember)
    {
        if (id != nvtmember.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(nvtmember);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NvtMemberExists(nvtmember.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(nvtmember);
    }

    // GET: NVTMEMBERS/Delete/5
    public async Task<IActionResult> Delete(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nvtmember = await _context.NvtMembers
            .FirstOrDefaultAsync(m => m.Id == id);
        if (nvtmember == null)
        {
            return NotFound();
        }

        return View(nvtmember);
    }

    // POST: NVTMEMBERS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long? id)
    {
        var nvtmember = await _context.NvtMembers.FindAsync(id);
        if (nvtmember != null)
        {
            _context.NvtMembers.Remove(nvtmember);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool NvtMemberExists(long? id)
    {
        return _context.NvtMembers.Any(e => e.Id == id);
    }
}
