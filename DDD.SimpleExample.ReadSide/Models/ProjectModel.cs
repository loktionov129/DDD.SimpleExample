﻿using System;
using System.Collections.Generic;
using DDD.SimpleExample.Common.Enums;
using DDD.SimpleExample.ReadSide.Helpers;

namespace DDD.SimpleExample.ReadSide.Models
{
    public class ProjectModel : BaseModel
    {
        private ProjectModel()
        {
        }
        public ProjectModel(Guid id) : base(id)
        {
        }

        public string CustomerId { get; set; }
        public string Name { get; set; }
        public ProjectStatus Status { get; set; }
        public CustomerModel CustomerModel { get; set; }
        public ICollection<UserModel> AssignedUsers { get; set; }
    }
}