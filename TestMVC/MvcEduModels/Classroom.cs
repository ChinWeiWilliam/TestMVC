﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace TestMVC.MvcEduModels
{
    public partial class Classroom
    {
        /// <summary>
        /// 編號
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 教室名稱
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 教室樓層
        /// </summary>
        public string Floor { get; set; }
        /// <summary>
        /// 教室狀態(使用中，空閒，維修中)
        /// </summary>
        public string ClassroomStatus { get; set; }
        /// <summary>
        /// 教室人數容量
        /// </summary>
        public int Capacity { get; set; }
        /// <summary>
        /// 教室分機
        /// </summary>
        public string Telephone { get; set; }
        /// <summary>
        /// 狀態
        /// </summary>
        public string Status { get; set; }
    }
}