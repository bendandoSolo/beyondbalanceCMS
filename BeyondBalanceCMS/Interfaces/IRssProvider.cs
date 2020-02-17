using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;

namespace BeyondBalance.Interfaces
{
    public interface IRssProvider
    {
        IEnumerable<SyndicationItem> GetItems();
    }

    public interface IRssProvider2
    {
        IEnumerable<SyndicationItem> GetItems();
    }



}
