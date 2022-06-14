using AutoMapper;
using DataModel.Entities;
using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Usres
{
    public class UserREp : IUser
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public UserREp(ApplicationDbContext db, IMapper _Mapper)
        {
            this.db = db;
            mapper = _Mapper;
        }
        public void add(UserVM dpt)
        {
            var data = mapper.Map<User>(dpt);

            db.user.Add(data);
            db.SaveChanges();
        }

        public void Edit(UserVM dpt)
        {
            var data = mapper.Map<User>(dpt);
            db.Entry(data).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            db.SaveChanges();
        }

        public UserVM GetById(int id)
        {
            var data = db.user.Where(z => z.Id == id).Select(a => new UserVM { Id = a.Id, Name = a.Name, Email = a.Email,job=a.job,phone=a.phone, cuntery = a.cuntery, Password = a.Password }).FirstOrDefault(); ;
            return data;
        }

        public string login(UserVM dpt)
        {
            var data = db.user.Where(z => z.Email == dpt.Email && z.Password == dpt.Password).Select(a => a.Id).FirstOrDefault();
            if (data.ToString() == null)
            {
                return null;

            }
            else
            {
                return data.ToString();

            }
        }
    }
}
