using CourseManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManager.Migrations.Seeds
{
    public class ActionLinkCreator
    {
        private readonly Coursemanger.Models.CourseManagerEntities _context;
        public ActionLinkCreator(Coursemanger.Models.CourseManagerEntities context)
        {
            _context = context;
        }

        public ActionLinkCreator()
        {
            // TODO: Complete member initialization
        }
        public void Seed()
        {
            var initialActionLinks = new List<ActionLinks>
           {
             new ActionLinks
             {
               Id=1,
               Name="主页",
               Contorller="Home",
               Action="Index"
             }
           };
            foreach (var action in initialActionLinks)
            {
                if (_context.ActionLinks.Any(r => r.Name == action.Name))
                {
                    continue;
                }
                _context.ActionLinks.Add(action);
            }
            _context.SaveChanges();
        }
    }
}