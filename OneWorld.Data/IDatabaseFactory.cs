using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWorld.Data
{
  public interface IDatabaseFactory
    {
        ERDDBContext Get();
    }
}
