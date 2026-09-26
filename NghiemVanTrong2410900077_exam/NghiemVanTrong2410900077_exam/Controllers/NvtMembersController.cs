
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NghiemVanTrong2410900077_exam.Models;

public class NvtMembersController : Controller
{
    private readonly NghiemVanTrongStudienContext _context;

    public NvtMembersController(NghiemVanTrongStudienContext context)
    {
        _context = context;
    }

    // GET: NVTMEMBERS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.NvtMembers.ToListAsync());
    }

    // GET: NVTMEMBERS/Details/5
    public async Task<IActionResult> Details(int? id)
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
    public async Task<IActionResult> Create([Bind("Id,Name,Gender,BirthDay,Email,Phone,Active")] NvtMember nvtmember)
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
    public async Task<IActionResult> Edit(int? id)
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
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Name,Gender,BirthDay,Email,Phone,Active")] NvtMember nvtmember)
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
    public async Task<IActionResult> Delete(int? id)
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
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var nvtmember = await _context.NvtMembers.FindAsync(id);
        if (nvtmember != null)
        {
            _context.NvtMembers.Remove(nvtmember);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool NvtMemberExists(int? id)
    {
        return _context.NvtMembers.Any(e => e.Id == id);
    }
}
