﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.BaseData.JobManagement.Dto
{
    public class CreateOrUpdateJobDto
    {
        public string Name { get; set; }

        public bool Enabled { get; set; }

        public int Sort { get; set; }
    }
}
