﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendancePC.Models.Entities
{
    public partial class Guest
    {
        public string Login { get => this.User.Login; }
    }
}
