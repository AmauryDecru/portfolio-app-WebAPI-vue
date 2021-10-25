﻿using Imi.Project.Api.Core.DTO_S.Base;
using Imi.Project.Api.Core.DTO_S.Categories;
using Imi.Project.Api.Core.DTO_S.DietaryRequirements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.DTO_S.Products
{
    public class ProductResponseDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public CategoryResponseDTO Category { get; set; }
        public DietaryRequirementResponseDTO DietaryRequirement{ get; set; }
    }
}
