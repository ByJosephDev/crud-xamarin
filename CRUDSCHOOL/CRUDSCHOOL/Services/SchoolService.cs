using System;
using System.Collections.Generic;
using System.Linq;
using CRUDSCHOOL.DataContext;
using CRUDSCHOOL.Models;

namespace CRUDSCHOOL.Services
{
    public class SchoolService
    {

        private readonly AppDbContext _context;

        public SchoolService() => _context = App.GetContext();

        public bool Create(School item)
        {
            try
            {
                //EntityFrameworkCore
                _context.Schools.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(School item)
        {
            try
            {
                //EntityFrameworkCore
                _context.Schools.Update(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(School item)
        {
            try
            {
                //EntityFrameworkCore
                _context.Schools.Remove(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<School> Get()
        {
            return _context.Schools.ToList();
        }

        public School getSchool(int id)
        {

            School item =
                _context.Schools.FirstOrDefault(s => s.SchoolId == id);

            return item;

        }


    }
}

