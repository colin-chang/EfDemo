using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfDemo.Domain
{
    /// <summary>
    /// 俱乐部
    /// </summary>
    public class Club
    {
        public int Id { get; set; }
        [Required, MaxLength(100)] 
        public string Name { get; set; }
        [MaxLength(20)] 
        public string City { get; set; }
        [Column(TypeName = "date")] 
        public DateTime EstablishedDate { get; set; }
        [MaxLength(200)] 
        public string History { get; set; }

        /// <summary>
        /// 所属联盟
        /// </summary>
        public League League { get; set; }

        /// <summary>
        /// 俱乐部球员
        /// </summary>
        public IEnumerable<Player> Players { get; set; } = new List<Player>();
    }
}