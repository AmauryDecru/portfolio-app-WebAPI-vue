using Imi.Project.Mobile.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Interfaces.IServices
{
    public interface IBaseService<T> where T: Base
    {
        Task<IList<T>> GetAll();
        Task<T> GetById(Guid id);
        Task<T> Update(T data);
        Task<T> Add(T data);
        Task<T> Delete(Guid id);
    }
}
