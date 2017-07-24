using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPostgre.Domain
{
    class SelectTestViewModel
    {
        private TestConnection dbc = new TestConnection("testman", "tetetete", "public");
        private List<Hoge> _test;

        public SelectTestViewModel()
        {
            _test = dbc.Table.ToList();
        }
        public List<Hoge> Test
        {
            get { return _test; }
        }
    }
}
