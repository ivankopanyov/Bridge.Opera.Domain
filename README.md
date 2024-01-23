# Bridge.Opera.Domain
#### _Библиотека, разработанная на языке C# на платформе .NET Framework 4.8.1, для взаимодействия с базой данных OPERA с помощью EntityFramework._

#### _Пример_

```cs
using Bridge.Opera.Domain;
using Bridge.Opera.Domain.Entities;
using Bridge.Opera.Domain.Entities.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Bridge.Example
{
    internal class Program
    {
        private const string NAME_DATA_QUERY = "select hrs_dev.hrs_sh_sens.dob(n.name_id) as BIRTHDAY, hrs_dev.hrs_sh_sens.pass_id(n.name_id) as PASS_ID from opera.name n where rownum <= 1 and n.name_id = {0}";

        public static async Task Main(string[] args)
        {
            using (var context = new OperaDbContext())
            {
                var name = await context.Names
                    .OrderByDescending(n => n.NameId)
                    .AsNoTracking()
                    .FirstOrDefaultAsync();

                if (name != null)
                {
                    var nameInfo = await context.NameData
                        .FromSqlRaw(string.Format(NAME_DATA_QUERY, name.NameId))
                        .FirstOrDefaultAsync();

                    name.BirthDateStr = nameInfo?.BirthDay;
                    name.Udfc01 = nameInfo?.PassId;

                    Console.WriteLine($"{name.First} {name.Last}, {name.BirthDateStr}, {name.Udfc01}");
                }

                Console.ReadKey();
            }
        }
    }

    internal class OperaDbContext : OperaDbContextBase
    {
        public virtual DbSet<Name> Names { get; set; }

        public virtual DbSet<NameData> NameData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=localhost/opera;User Id=opera;Password=opera;";

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseOracle(connectionString, options => options
                    .UseOracleSQLCompatibility("11"));
            }
        }
    }
}
```
