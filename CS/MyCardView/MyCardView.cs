using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid;

namespace MyCardView
{
    public class MyCardView : CardView
    {
        public MyCardView(DevExpress.XtraGrid.GridControl ownerGrid)
            : base(ownerGrid)
        {
            // put your initialization code here
        }
        public MyCardView()
        {           
        }
        protected override string ViewName { get { return "MyCardView"; } }
    }
}
