using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.Grid.Handler;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Card.Handler;
using DevExpress.XtraGrid.Views.Card;

namespace MyCardView
{
    public class MyCardHandler : CardHandler
    {
        public MyCardHandler(CardView cv)
            : base(cv)
        {
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyData == Keys.Delete && View.State == CardState.Normal)
                View.DeleteRow(View.FocusedRowHandle);
        }
    }
}
