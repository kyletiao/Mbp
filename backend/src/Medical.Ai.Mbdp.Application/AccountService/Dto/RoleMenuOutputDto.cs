﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Medical.Ai.Mbdp.Application.AccountService.Dto
{
    public class RoleMenuOutputDto
    {
        public int RoleId { get; set; }

        public int MenuId { get; set; }

        public string MenuName { get; set; }

        public string MenuCode { get; set; }

        public int MenuLevel { get; set; }

        public int ParentId { get; set; }

        public string Path { get; set; }
    }
}
