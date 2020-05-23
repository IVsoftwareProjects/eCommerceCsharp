using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.database
{
    public class AplicationDBContext : DbContext
    {
        AccessViolationException(DbContextOptions<AplicationDBContext> options) : base(options){}
    }
}
