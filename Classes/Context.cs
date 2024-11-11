using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace KT7_SkalochkinFedor_ISP321_MasterPol.Classes
{
    public class Context:DbContext
    {
        public  DbSet<Database> databases { get; set; }
        public static Context context;
        
        public static Context GetContext()
        {
            if (context == null)
            {
                context = new Context();
            }
            return context;
        }
        public Context() : base("name=KT7_SkalochkinFedor_ISP321_MasterPolEntities")
        {

        }
        
    }
}
