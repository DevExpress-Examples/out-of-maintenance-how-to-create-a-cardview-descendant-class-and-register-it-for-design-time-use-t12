using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.Card.ViewInfo;
using DevExpress.XtraGrid.Views.Card;
using System.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace MyCardView
{
    public class MyCardViewInfo : CardViewInfo
    {
        public MyCardViewInfo(DevExpress.XtraGrid.Views.Card.CardView view)
            : base(view)
        {
            
        }
    }
}
