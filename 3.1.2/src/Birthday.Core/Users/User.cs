using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static Birthday.Enum.Enums;

namespace Birthday.Users
{
    [Table("User")]
    public class User : FullAuditedEntity
    {
        public const int MaxNicknameLength = 32;
        /// <summary>
        /// 昵称
        /// </summary>
        public string Nickname { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public Gender Sex { get; set; }
        /// <summary>
        /// 星座
        /// </summary>
        public Astro Astro { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        [Required]
        public string PhoneNum { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        [Required]
        public string Email { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [Required]
        public string Pwd { get; set; }

        /// <summary>
        /// 关联Person外键
        /// </summary>
        public Guid? PersonId { get; set; }
        /// <summary>
        /// 外键实体
        /// </summary>
        [ForeignKey("PersonId")]
        public Persons.Person DetailInfo { get; set; }
    }
}
