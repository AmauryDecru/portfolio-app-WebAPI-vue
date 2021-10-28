﻿using Imi.Project.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Infrastructure
{
    public interface IBlogPostRepository : IBaseRepository<BlogPost>
    {
        Task<IEnumerable<BlogPost>> SearchAsync(string search);
    }
}
