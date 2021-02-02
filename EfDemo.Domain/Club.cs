using System;
using System.Collections.Generic;

namespace EfDemo.Domain
{
    /// <summary>
    /// 俱乐部
    /// </summary>
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public DateTime EstablishedDate { get; set; }
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