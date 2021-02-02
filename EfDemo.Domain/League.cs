using System.Collections.Generic;

namespace EfDemo.Domain
{
    /// <summary>
    /// 联盟
    /// </summary>
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        private IDictionary<string, int> _clubs { get; set; } = new Dictionary<string, int>();

        private IEnumerable<League> _leagues;

        public int this[string index]
        {
            get
            {
                if (!_clubs.ContainsKey(index))
                    return -1;

                return _clubs[index];
            }

            set
            {
                if (value > 150 || value <= 0)
                    return;
                _clubs[index] = value;
            }
        }

        public void Test()
        {
            var l = new League();
            l["Colin"] = 12;

            // var adults = _numbers.Where(age => age >= 18);
            
            // var ages= _leagues.Where(l => l.Age >= 18).Select(l => l.Age);
            // var a= from l1 in _leagues select l1.Age where l1.Age >= 18;
            
            // Ado.Net
            // using (var IDbconnection = new MySqlConnection("")) ;
            // {
            //     var using ICommand =new DbCommand();
            //     {
            //         MySqlConnection.o
            //     }
            // }
            
            // SqlHelper

            // ORM
            // StackOverflow -> SqlHelper Dapper 
            // EF Core
            // Hebinet  


        }
    }
}