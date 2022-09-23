﻿using FreeSql.DataAnnotations;
using System;
using System.Collections.Generic;
using ZhonTai.Admin.Domain.Organization;

namespace ZhonTai.Admin.Domain.Employee.Input;

/// <summary>
/// 添加
/// </summary>
public class EmployeeAddInput
{
    /// <summary>
    /// 工号
    /// </summary>
    public string JobNumber { get; set; }

    /// <summary>
    /// 性别
    /// </summary>
    public SexEnum? Sex { get; set; }

    /// <summary>
    /// 主属部门Id
    /// </summary>
    public long MainOrgId { get; set; }

    /// <summary>
    /// 所属部门
    /// </summary>
    public long[] OrgIds { get; set; }

    public ICollection<OrganizationEntity> Orgs { get; set; }

    /// <summary>
    /// 职位
    /// </summary>
    public string Position { get; set; }

    /// <summary>
    /// 入职时间
    /// </summary>
    public DateTime? EntryTime { get; set; }
}