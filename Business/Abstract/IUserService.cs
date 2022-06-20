using Core.Utilities.Results;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int id);
        void Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
    }
}
