﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationTube.Models
{
     public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
    }
}
