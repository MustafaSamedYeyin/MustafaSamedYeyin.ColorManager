using Core.Entities;
using Core.Interfaces.Data.Repository;
using Data.EfCore.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Data.EfCore.Repositories
{
    public class ColorRepository : IColorRepository
    {

        private readonly ColorManagerContext _colorManagerContext;

        public ColorRepository(ColorManagerContext colorManagerContext)
        {
            _colorManagerContext = colorManagerContext;
        }

        public async Task<List<Color>> GetColorsByUserId(int id)
        {
            return await _colorManagerContext.Colors!.Join(_colorManagerContext.ColorPalattes!, c => c.Id, cp => cp.ColorId, (c,cp) => new
            {
                c = c,
                cp = cp
            }).Join(_colorManagerContext.Palattes!,i => i.cp.PalatteId,p => p.ColorPalatteId,(tt,p) => new
            {
                tt = tt ,
                p = p
            }).Join(_colorManagerContext.PalatteCategories!, i => i.tt.cp.PalatteId, pc => pc.PalatteId,(ttt,pc) => new
            {
                ttt = ttt ,
                pc = pc
            }).Join(_colorManagerContext.Categories!, i=> i.pc.CategoryId,i=> i.Id, (tttt, c) => new
            {
                tttt = tttt,
                c = c
            }).Where(i  => i.c.UserId == id).Select(i=> new Color()
            {
                Id = i.tttt.ttt.tt.c.Id,
                ColorPalatte = i.tttt.ttt.tt.c.ColorPalatte,
                Hex = i.tttt.ttt.tt.c.Hex,
                Rgb = i.tttt.ttt.tt.c.Rgb,
                Rgba = i.tttt.ttt.tt.c.Rgba,
            }).ToListAsync();
        }
    }
}