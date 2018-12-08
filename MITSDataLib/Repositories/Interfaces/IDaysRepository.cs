﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MITSDataLib.Models;

namespace MITSDataLib.Repositories.Interfaces
{
    public interface IDaysRepository
    {
        Task<List<Day>> GetDays();
    }
}