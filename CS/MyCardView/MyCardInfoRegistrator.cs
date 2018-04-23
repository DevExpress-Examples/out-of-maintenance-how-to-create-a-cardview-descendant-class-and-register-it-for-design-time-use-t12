using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.Handler;
using DevExpress.XtraGrid.Views.Base.ViewInfo;

namespace MyCardView
{
    public class MyCardInfoRegistrator : CardInfoRegistrator
    {
        public override string ViewName { get { return "MyCardView"; } }
        public override BaseView CreateView(GridControl grid) { return new MyCardView(grid as GridControl); }
        public override BaseViewInfo CreateViewInfo(BaseView view){ return new MyCardViewInfo(view as MyCardView); }
        public override BaseViewHandler CreateHandler(BaseView view) { return new MyCardHandler(view as MyCardView); }
    }
}
