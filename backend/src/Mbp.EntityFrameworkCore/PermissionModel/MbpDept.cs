﻿using Mbp.Core.Entity;
using Mbp.Core.Entity.Aggregate;
using Mbp.EntityFrameworkCore.PermissionModel.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mbp.EntityFrameworkCore.PermissionModel
{
    public class MbpDept : AggregateBase<int>, ISoftDelete
    {
        /// <summary>
        /// 部门名称
        /// </summary>
        [MaxLength(256)]
        public string DeptName { get; set; }

        /// <summary>
        /// 部门名称全称
        /// </summary>
        [MaxLength(1024)]
        public string FullDeptName { get; set; }

        /// <summary>
        /// 部门编号
        /// </summary>
        [MaxLength(256)]
        public string DeptCode { get; set; }

        /// <summary>
        /// 上级部门名称
        /// </summary>
        public string ParentDeptName { get; set; }

        /// <summary>
        /// 上级部门编号
        /// </summary>
        [MaxLength(256)]
        public string ParentDeptCode { get; set; }

        /// <summary>
        /// 上级部门Id
        /// </summary>
        public int? ParentId { get; set; }

        [ForeignKey("ParentId")]
        public MbpDept ParentDept { get; set; }

        public List<MbpDept> ChildrenDept { get; set; } = new List<MbpDept>();

        /// <summary>
        /// 部门状态
        /// </summary>
        public EnumDeptStatus DeptStatus { get; set; }

        /// <summary>
        /// 层级
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Order { get; set; }

        public bool IsDeleted { get; set; }

        public string SystemCode { get; set; }
    }
}
